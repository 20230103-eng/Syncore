using System;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace Modelo.Modelo.Infraestructura
{
    public static class ArchivosSeguros
    {
        public static string EnlaceManualUsuario = "https://drive.google.com/file/d/1ixbYhtlWgLX0gxpWu3BRoicGN-3rLLp1/view?usp=sharing";

        public static byte[] LeerBytes(string ruta)
        {
            try
            {
                return File.ReadAllBytes(ruta);
            }
            catch (IOException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Archivos");
            }
            catch (UnauthorizedAccessException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Archivos");
            }
            catch (ArgumentException)
            {
                CatalogoErrores.Mostrar("ERR-VAL-006", "Archivos");
            }
            return null;
        }

        public static string LeerTexto(string ruta)
        {
            try
            {
                return File.ReadAllText(ruta);
            }
            catch (IOException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Archivos");
            }
            catch (UnauthorizedAccessException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Archivos");
            }
            return null;
        }

        public static bool GuardarTexto(string ruta, string contenido)
        {
            try
            {
                File.WriteAllText(ruta, contenido);
                return true;
            }
            catch (IOException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Archivos");
            }
            catch (UnauthorizedAccessException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Archivos");
            }
            return false;
        }

        public static bool Eliminar(string ruta)
        {
            try
            {
                File.Delete(ruta);
                return true;
            }
            catch (IOException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Archivos");
            }
            catch (UnauthorizedAccessException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Archivos");
            }
            return false;
        }

        public static Image CrearImagen(byte[] datos)
        {
            if (datos == null || datos.Length == 0)
            {
                return null;
            }
            try
            {
                using (MemoryStream flujo = new MemoryStream(datos))
                {
                    using (Image original = Image.FromStream(flujo))
                    {
                        return new Bitmap(original);
                    }
                }
            }
            catch (ArgumentException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Logotipo");
            }
            return null;
        }

        public static bool AbrirArchivo(string ruta)
        {
            try
            {
                Process.Start(ruta);
                return true;
            }
            catch (Win32Exception)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Evidencias");
            }
            catch (IOException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Evidencias");
            }
            catch (UnauthorizedAccessException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Evidencias");
            }
            catch (InvalidOperationException)
            {
                CatalogoErrores.Mostrar("ERR-APP-001", "Evidencias");
            }
            catch (ArgumentException)
            {
                CatalogoErrores.Mostrar("ERR-VAL-006", "Evidencias");
            }
            return false;
        }


        public static bool AbrirEnlace(string enlace)
        {
            try
            {
                Process.Start(enlace);
                return true;
            }
            catch (Win32Exception)
            {
                CatalogoErrores.Mostrar("ERR-APP-004", "Manual de usuario");
            }
            catch (InvalidOperationException)
            {
                CatalogoErrores.Mostrar("ERR-APP-004", "Manual de usuario");
            }
            catch (ArgumentException)
            {
                CatalogoErrores.Mostrar("ERR-APP-004", "Manual de usuario");
            }
            return false;
        }

        public static bool GuardarExcel(DataTable datos, string nombre, string descripcion, string ruta)
        {
            try
            {
                ExportadorExcel.Guardar(datos, nombre, descripcion, ruta);
                return true;
            }
            catch (IOException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Reportes");
            }
            catch (UnauthorizedAccessException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Reportes");
            }
            return false;
        }
        public static bool GuardarDetalleProyectoPdf(DataRow proyecto, DataTable equipo, DataTable hitos,
            decimal avanceReal, decimal avancePlanificado, int tareas, int completadas,
            int vencidas, string ruta)
        {
            try
            {
                ExportadorPdf.GuardarDetalleProyecto(proyecto, equipo, hitos, avanceReal,
                    avancePlanificado, tareas, completadas, vencidas, ruta);
                return true;
            }
            catch (IOException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Exportación PDF");
            }
            catch (UnauthorizedAccessException)
            {
                CatalogoErrores.Mostrar("ERR-APP-002", "Exportación PDF");
            }
            catch (ArgumentException)
            {
                CatalogoErrores.Mostrar("ERR-VAL-006", "Exportación PDF");
            }
            return false;
        }

    }
}
