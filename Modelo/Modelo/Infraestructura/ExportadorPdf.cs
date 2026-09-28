using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;

namespace Modelo.Modelo.Infraestructura
{
    public static class ExportadorPdf
    {
        private sealed class Pagina
        {
            public StringBuilder Contenido = new StringBuilder();
            public int Altura = 748;
        }

        private sealed class Documento
        {
            public List<Pagina> Paginas = new List<Pagina>();
            public Pagina Actual;

            public Documento()
            {
                NuevaPagina();
            }

            public void NuevaPagina()
            {
                Actual = new Pagina();
                Paginas.Add(Actual);
                Actual.Contenido.Append("0.06 0.24 0.44 rg 48 790 500 2 re f\n");
                Texto("SYNCORE  /  DETALLE DE PROYECTO", 48, 768, 10, true);
                Actual.Altura = 735;
            }

            public void Texto(string contenido, int x, int y, int tamano, bool negrita)
            {
                Actual.Contenido.Append("0.14 0.20 0.30 rg BT /");
                if (negrita)
                {
                    Actual.Contenido.Append("F2 ");
                }
                else
                {
                    Actual.Contenido.Append("F1 ");
                }
                Actual.Contenido.Append(tamano.ToString(CultureInfo.InvariantCulture));
                Actual.Contenido.Append(" Tf 1 0 0 1 ");
                Actual.Contenido.Append(x.ToString(CultureInfo.InvariantCulture));
                Actual.Contenido.Append(' ');
                Actual.Contenido.Append(y.ToString(CultureInfo.InvariantCulture));
                Actual.Contenido.Append(" Tm (");
                Actual.Contenido.Append(Escapar(contenido));
                Actual.Contenido.Append(") Tj ET\n");
            }

            public void Linea(string contenido, bool negrita)
            {
                if (Actual.Altura < 65)
                {
                    NuevaPagina();
                }
                if (negrita)
                {
                    Texto(contenido, 48, Actual.Altura, 11, true);
                    Actual.Altura = Actual.Altura - 19;
                }
                else
                {
                    Texto(contenido, 48, Actual.Altura, 10, false);
                    Actual.Altura = Actual.Altura - 15;
                }
            }

            public void Campo(string nombre, string valor)
            {
                Linea(nombre + ":", true);
                Parrafo(valor);
                Actual.Altura = Actual.Altura - 5;
            }

            public void Seccion(string titulo)
            {
                if (Actual.Altura < 110)
                {
                    NuevaPagina();
                }
                Actual.Altura = Actual.Altura - 8;
                Linea(titulo.ToUpperInvariant(), true);
                Actual.Contenido.Append("0.80 0.85 0.90 rg 48 ");
                Actual.Contenido.Append((Actual.Altura + 5).ToString(CultureInfo.InvariantCulture));
                Actual.Contenido.Append(" 500 1 re f\n");
                Actual.Altura = Actual.Altura - 7;
            }

            public void Parrafo(string valor)
            {
                if (valor == null)
                {
                    valor = "";
                }
                string texto = valor.Replace('\r', ' ').Replace('\n', ' ').Trim();
                if (texto.Length == 0)
                {
                    Linea("Sin información", false);
                    return;
                }
                string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder linea = new StringBuilder();
                for (int indice = 0; indice < palabras.Length; indice = indice + 1)
                {
                    string palabra = palabras[indice];
                    if (linea.Length + palabra.Length + 1 > 72 && linea.Length > 0)
                    {
                        Linea(linea.ToString(), false);
                        linea.Clear();
                    }
                    while (palabra.Length > 45)
                    {
                        if (linea.Length > 0)
                        {
                            Linea(linea.ToString(), false);
                            linea.Clear();
                        }
                        Linea(palabra.Substring(0, 45), false);
                        palabra = palabra.Substring(45);
                    }
                    if (linea.Length > 0)
                    {
                        linea.Append(' ');
                    }
                    linea.Append(palabra);
                }
                if (linea.Length > 0)
                {
                    Linea(linea.ToString(), false);
                }
            }
        }

        public static void GuardarDetalleProyecto(DataRow proyecto, DataTable equipo, DataTable hitos,
            decimal avanceReal, decimal avancePlanificado, int tareas, int completadas,
            int vencidas, string ruta)
        {
            Documento documento = new Documento();
            documento.Seccion("Información general");
            documento.Campo("Proyecto", Valor(proyecto, "Proyecto"));
            documento.Campo("Código", Valor(proyecto, "Codigo"));
            documento.Campo("Responsable", Valor(proyecto, "Responsable"));
            documento.Campo("Área / tipo", Valor(proyecto, "Area") + " / " + Valor(proyecto, "TipoProyecto"));
            documento.Campo("Estado / prioridad", Valor(proyecto, "Estado") + " / " + Valor(proyecto, "Prioridad"));
            documento.Campo("Período", Fecha(proyecto, "FechaInicio") + " - " + Fecha(proyecto, "FechaCierreEstimada"));
            documento.Campo("Objetivo", Valor(proyecto, "Objetivo"));
            documento.Campo("Resultado esperado", Valor(proyecto, "ResultadoEsperado"));
            documento.Seccion("Indicadores");
            documento.Linea("Avance real: " + avanceReal.ToString("0.##") + "%   |   Avance planificado: " +
                avancePlanificado.ToString("0.##") + "%", false);
            documento.Linea("Tareas: " + tareas + "   |   Completadas: " + completadas +
                "   |   Vencidas: " + vencidas, false);
            documento.Seccion("Equipo de trabajo (" + equipo.Rows.Count + ")");
            if (equipo.Rows.Count == 0)
            {
                documento.Linea("Sin integrantes activos.", false);
            }
            foreach (DataRow integrante in equipo.Rows)
            {
                documento.Parrafo(Valor(integrante, "NombreCompleto") + " - " +
                    Valor(integrante, "RolProyecto") + " - " + Valor(integrante, "Area"));
            }
            documento.Seccion("Hitos y entregables (" + hitos.Rows.Count + ")");
            if (hitos.Rows.Count == 0)
            {
                documento.Linea("Sin hitos registrados.", false);
            }
            foreach (DataRow hito in hitos.Rows)
            {
                documento.Parrafo(Valor(hito, "Hito"));
                documento.Parrafo("Fecha: " + Fecha(hito, "FechaObjetivo") + " | Responsable: " +
                    Valor(hito, "Responsable") + " | Estado: " + Valor(hito, "Estado"));
            }
            GuardarPaginas(documento.Paginas, ruta);
        }

        private static string Valor(DataRow fila, string columna)
        {
            if (fila.IsNull(columna))
            {
                return "Sin información";
            }
            return fila[columna].ToString();
        }

        private static string Fecha(DataRow fila, string columna)
        {
            if (fila.IsNull(columna))
            {
                return "Sin fecha";
            }
            return Convert.ToDateTime(fila[columna]).ToString("dd/MM/yyyy");
        }

        private static string Escapar(string texto)
        {
            return texto.Replace("\\", "\\\\").Replace("(", "\\(").Replace(")", "\\)")
                .Replace("\t", " ");
        }

        private static void GuardarPaginas(List<Pagina> paginas, string ruta)
        {
            Encoding codificacion = Encoding.GetEncoding(1252);
            List<byte[]> objetos = new List<byte[]>();
            objetos.Add(null);
            objetos.Add(codificacion.GetBytes("<< /Type /Catalog /Pages 2 0 R >>"));
            StringBuilder hijos = new StringBuilder();
            for (int indice = 0; indice < paginas.Count; indice = indice + 1)
            {
                hijos.Append((5 + indice * 2).ToString(CultureInfo.InvariantCulture));
                hijos.Append(" 0 R ");
            }
            objetos.Add(codificacion.GetBytes("<< /Type /Pages /Kids [" + hijos.ToString() +
                "] /Count " + paginas.Count.ToString(CultureInfo.InvariantCulture) + " >>"));
            objetos.Add(codificacion.GetBytes("<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica /Encoding /WinAnsiEncoding >>"));
            objetos.Add(codificacion.GetBytes("<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica-Bold /Encoding /WinAnsiEncoding >>"));
            for (int indice = 0; indice < paginas.Count; indice = indice + 1)
            {
                int pagina = 5 + indice * 2;
                string diccionario = "<< /Type /Page /Parent 2 0 R /MediaBox [0 0 595 842] " +
                    "/Resources << /Font << /F1 3 0 R /F2 4 0 R >> >> /Contents " +
                    (pagina + 1).ToString(CultureInfo.InvariantCulture) + " 0 R >>";
                objetos.Add(codificacion.GetBytes(diccionario));
                StringBuilder contenido = paginas[indice].Contenido;
                contenido.Append("0.48 0.52 0.60 rg BT /F1 9 Tf 1 0 0 1 48 34 Tm (");
                contenido.Append(Escapar("Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") +
                    "     Página " + (indice + 1) + " de " + paginas.Count));
                contenido.Append(") Tj ET\n");
                byte[] bytes = codificacion.GetBytes(contenido.ToString());
                byte[] prefijo = codificacion.GetBytes("<< /Length " + bytes.Length + " >>\nstream\n");
                byte[] sufijo = codificacion.GetBytes("\nendstream");
                byte[] objeto = new byte[prefijo.Length + bytes.Length + sufijo.Length];
                Buffer.BlockCopy(prefijo, 0, objeto, 0, prefijo.Length);
                Buffer.BlockCopy(bytes, 0, objeto, prefijo.Length, bytes.Length);
                Buffer.BlockCopy(sufijo, 0, objeto, prefijo.Length + bytes.Length, sufijo.Length);
                objetos.Add(objeto);
            }
            using (FileStream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write))
            {
                byte[] encabezado = codificacion.GetBytes("%PDF-1.4\n");
                archivo.Write(encabezado, 0, encabezado.Length);
                List<long> posiciones = new List<long>();
                posiciones.Add(0);
                for (int indice = 1; indice < objetos.Count; indice = indice + 1)
                {
                    posiciones.Add(archivo.Position);
                    byte[] inicio = codificacion.GetBytes(indice.ToString(CultureInfo.InvariantCulture) + " 0 obj\n");
                    archivo.Write(inicio, 0, inicio.Length);
                    archivo.Write(objetos[indice], 0, objetos[indice].Length);
                    byte[] fin = codificacion.GetBytes("\nendobj\n");
                    archivo.Write(fin, 0, fin.Length);
                }
                long inicioXref = archivo.Position;
                byte[] encabezadoXref = codificacion.GetBytes("xref\n0 " + objetos.Count + "\n0000000000 65535 f \n");
                archivo.Write(encabezadoXref, 0, encabezadoXref.Length);
                for (int indice = 1; indice < posiciones.Count; indice = indice + 1)
                {
                    byte[] fila = codificacion.GetBytes(posiciones[indice].ToString("D10", CultureInfo.InvariantCulture) + " 00000 n \n");
                    archivo.Write(fila, 0, fila.Length);
                }
                byte[] cierre = codificacion.GetBytes("trailer\n<< /Size " + objetos.Count + " /Root 1 0 R >>\nstartxref\n" +
                    inicioXref.ToString(CultureInfo.InvariantCulture) + "\n%%EOF\n");
                archivo.Write(cierre, 0, cierre.Length);
            }
        }
    }
}
