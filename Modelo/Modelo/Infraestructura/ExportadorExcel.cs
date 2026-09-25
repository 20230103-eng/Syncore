using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Xml;

namespace Modelo.Modelo.Infraestructura
{
    public static class ExportadorExcel
    {
        private const string Hoja = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
        private const string Relaciones = "http://schemas.openxmlformats.org/officeDocument/2006/relationships";
        private const string Paquete = "http://schemas.openxmlformats.org/package/2006/relationships";
        private const string Tipos = "http://schemas.openxmlformats.org/package/2006/content-types";

        public static void Guardar(DataTable datos, string titulo, string detalle, string ruta)
        {
            using (FileStream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write))
            using (ZipArchive zip = new ZipArchive(archivo, ZipArchiveMode.Create))
            {
                CrearTipos(zip);
                CrearRelacionPrincipal(zip);
                CrearLibro(zip);
                CrearRelacionLibro(zip);
                CrearEstilos(zip);
                CrearHoja(zip, datos, titulo, detalle);
            }
        }

        private static XmlWriter AbrirXml(ZipArchive zip, string nombre)
        {
            ZipArchiveEntry entrada = zip.CreateEntry(nombre);
            XmlWriterSettings opciones = new XmlWriterSettings();
            opciones.Encoding = new System.Text.UTF8Encoding(false);
            opciones.Indent = false;
            return XmlWriter.Create(entrada.Open(), opciones);
        }

        private static void CrearTipos(ZipArchive zip)
        {
            using (XmlWriter xml = AbrirXml(zip, "[Content_Types].xml"))
            {
                xml.WriteStartElement("Types", Tipos);
                xml.WriteStartElement("Default", Tipos);
                xml.WriteAttributeString("Extension", "rels");
                xml.WriteAttributeString("ContentType", "application/vnd.openxmlformats-package.relationships+xml");
                xml.WriteEndElement();
                xml.WriteStartElement("Default", Tipos);
                xml.WriteAttributeString("Extension", "xml");
                xml.WriteAttributeString("ContentType", "application/xml");
                xml.WriteEndElement();
                TipoParte(xml, "/xl/workbook.xml", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml");
                TipoParte(xml, "/xl/worksheets/sheet1.xml", "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml");
                TipoParte(xml, "/xl/styles.xml", "application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml");
                xml.WriteEndElement();
            }
        }

        private static void TipoParte(XmlWriter xml, string nombre, string tipo)
        {
            xml.WriteStartElement("Override", Tipos);
            xml.WriteAttributeString("PartName", nombre);
            xml.WriteAttributeString("ContentType", tipo);
            xml.WriteEndElement();
        }

        private static void CrearRelacionPrincipal(ZipArchive zip)
        {
            using (XmlWriter xml = AbrirXml(zip, "_rels/.rels"))
            {
                xml.WriteStartElement("Relationships", Paquete);
                Relacion(xml, "rId1", Relaciones + "/officeDocument", "xl/workbook.xml");
                xml.WriteEndElement();
            }
        }

        private static void CrearLibro(ZipArchive zip)
        {
            using (XmlWriter xml = AbrirXml(zip, "xl/workbook.xml"))
            {
                xml.WriteStartElement("workbook", Hoja);
                xml.WriteAttributeString("xmlns", "r", null, Relaciones);
                xml.WriteStartElement("sheets", Hoja);
                xml.WriteStartElement("sheet", Hoja);
                xml.WriteAttributeString("name", "Reporte");
                xml.WriteAttributeString("sheetId", "1");
                xml.WriteAttributeString("r", "id", Relaciones, "rId1");
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndElement();
            }
        }

        private static void CrearRelacionLibro(ZipArchive zip)
        {
            using (XmlWriter xml = AbrirXml(zip, "xl/_rels/workbook.xml.rels"))
            {
                xml.WriteStartElement("Relationships", Paquete);
                Relacion(xml, "rId1", Relaciones + "/worksheet", "worksheets/sheet1.xml");
                Relacion(xml, "rId2", Relaciones + "/styles", "styles.xml");
                xml.WriteEndElement();
            }
        }

        private static void Relacion(XmlWriter xml, string id, string tipo, string destino)
        {
            xml.WriteStartElement("Relationship", Paquete);
            xml.WriteAttributeString("Id", id);
            xml.WriteAttributeString("Type", tipo);
            xml.WriteAttributeString("Target", destino);
            xml.WriteEndElement();
        }

        private static void CrearEstilos(ZipArchive zip)
        {
            using (XmlWriter xml = AbrirXml(zip, "xl/styles.xml"))
            {
                xml.WriteStartElement("styleSheet", Hoja);
                xml.WriteRaw("<numFmts count=\"1\"><numFmt numFmtId=\"164\" formatCode=\"dd/mm/yyyy\"/></numFmts>" +
                    "<fonts count=\"3\"><font><sz val=\"11\"/><name val=\"Calibri\"/></font>" +
                    "<font><b/><sz val=\"16\"/><color rgb=\"FF003D75\"/><name val=\"Calibri\"/></font>" +
                    "<font><b/><sz val=\"11\"/><color rgb=\"FFFFFFFF\"/><name val=\"Calibri\"/></font></fonts>" +
                    "<fills count=\"3\"><fill><patternFill patternType=\"none\"/></fill>" +
                    "<fill><patternFill patternType=\"gray125\"/></fill>" +
                    "<fill><patternFill patternType=\"solid\"><fgColor rgb=\"FF003D75\"/><bgColor indexed=\"64\"/></patternFill></fill></fills>" +
                    "<borders count=\"1\"><border><left/><right/><top/><bottom/><diagonal/></border></borders>" +
                    "<cellStyleXfs count=\"1\"><xf numFmtId=\"0\" fontId=\"0\" fillId=\"0\" borderId=\"0\"/></cellStyleXfs>" +
                    "<cellXfs count=\"4\"><xf numFmtId=\"0\" fontId=\"0\" fillId=\"0\" borderId=\"0\" xfId=\"0\"/>" +
                    "<xf numFmtId=\"0\" fontId=\"1\" fillId=\"0\" borderId=\"0\" xfId=\"0\" applyFont=\"1\"/>" +
                    "<xf numFmtId=\"0\" fontId=\"2\" fillId=\"2\" borderId=\"0\" xfId=\"0\" applyFont=\"1\" applyFill=\"1\"/>" +
                    "<xf numFmtId=\"164\" fontId=\"0\" fillId=\"0\" borderId=\"0\" xfId=\"0\" applyNumberFormat=\"1\"/>" +
                    "</cellXfs>");
                xml.WriteEndElement();
            }
        }

        private static void CrearHoja(ZipArchive zip, DataTable datos, string titulo, string detalle)
        {
            using (XmlWriter xml = AbrirXml(zip, "xl/worksheets/sheet1.xml"))
            {
                xml.WriteStartElement("worksheet", Hoja);
                xml.WriteStartElement("sheetViews", Hoja);
                xml.WriteStartElement("sheetView", Hoja);
                xml.WriteAttributeString("workbookViewId", "0");
                xml.WriteStartElement("pane", Hoja);
                xml.WriteAttributeString("ySplit", "4");
                xml.WriteAttributeString("topLeftCell", "A5");
                xml.WriteAttributeString("activePane", "bottomLeft");
                xml.WriteAttributeString("state", "frozen");
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteStartElement("cols", Hoja);
                xml.WriteStartElement("col", Hoja);
                xml.WriteAttributeString("min", "1");
                xml.WriteAttributeString("max", Math.Max(1, datos.Columns.Count).ToString());
                xml.WriteAttributeString("width", "26");
                xml.WriteAttributeString("customWidth", "1");
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteStartElement("sheetData", Hoja);
                FilaTexto(xml, 1, titulo, 1);
                FilaTexto(xml, 2, detalle + " | Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), 0);
                xml.WriteStartElement("row", Hoja);
                xml.WriteAttributeString("r", "4");
                for (int columna = 0; columna < datos.Columns.Count; columna = columna + 1)
                {
                    CeldaTexto(xml, ColumnaExcel(columna + 1) + "4", datos.Columns[columna].ColumnName, 2);
                }
                xml.WriteEndElement();
                for (int indice = 0; indice < datos.Rows.Count; indice = indice + 1)
                {
                    int numeroFila = indice + 5;
                    xml.WriteStartElement("row", Hoja);
                    xml.WriteAttributeString("r", numeroFila.ToString());
                    for (int columna = 0; columna < datos.Columns.Count; columna = columna + 1)
                    {
                        object valor = datos.Rows[indice][columna];
                        string celda = ColumnaExcel(columna + 1) + numeroFila;
                        if (valor == DBNull.Value || valor == null)
                        {
                            CeldaTexto(xml, celda, "", 0);
                        }
                        else if (valor is byte || valor is short || valor is int || valor is long || valor is float || valor is double || valor is decimal)
                        {
                            xml.WriteStartElement("c", Hoja);
                            xml.WriteAttributeString("r", celda);
                            xml.WriteStartElement("v", Hoja);
                            xml.WriteString(Convert.ToString(valor, CultureInfo.InvariantCulture));
                            xml.WriteEndElement();
                            xml.WriteEndElement();
                        }
                        else if (valor is DateTime)
                        {
                            xml.WriteStartElement("c", Hoja);
                            xml.WriteAttributeString("r", celda);
                            xml.WriteAttributeString("s", "3");
                            xml.WriteStartElement("v", Hoja);
                            xml.WriteString(Convert.ToDateTime(valor).ToOADate().ToString(CultureInfo.InvariantCulture));
                            xml.WriteEndElement();
                            xml.WriteEndElement();
                        }
                        else
                        {
                            CeldaTexto(xml, celda, valor.ToString(), 0);
                        }
                    }
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
                if (datos.Columns.Count > 0)
                {
                    xml.WriteStartElement("autoFilter", Hoja);
                    xml.WriteAttributeString("ref", "A4:" + ColumnaExcel(datos.Columns.Count) + Math.Max(4, datos.Rows.Count + 4));
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }
        }

        private static void FilaTexto(XmlWriter xml, int numero, string texto, int estilo)
        {
            xml.WriteStartElement("row", Hoja);
            xml.WriteAttributeString("r", numero.ToString());
            CeldaTexto(xml, "A" + numero, texto, estilo);
            xml.WriteEndElement();
        }

        private static void CeldaTexto(XmlWriter xml, string referencia, string texto, int estilo)
        {
            xml.WriteStartElement("c", Hoja);
            xml.WriteAttributeString("r", referencia);
            xml.WriteAttributeString("s", estilo.ToString());
            xml.WriteAttributeString("t", "inlineStr");
            xml.WriteStartElement("is", Hoja);
            xml.WriteStartElement("t", Hoja);
            xml.WriteString(texto);
            xml.WriteEndElement();
            xml.WriteEndElement();
            xml.WriteEndElement();
        }

        private static string ColumnaExcel(int numero)
        {
            string letras = "";
            while (numero > 0)
            {
                numero = numero - 1;
                letras = Convert.ToChar('A' + numero % 26) + letras;
                numero = numero / 26;
            }
            return letras;
        }
    }
}
