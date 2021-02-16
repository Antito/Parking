using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EstacionamientoTPFinal
{
    public class XMLCierres
    {
        private string RutaArchivo = @"C:\Manager\cierres.xml";

        public void GenerarXMLCierres(List<Cierre> ListaCierre)
        {
            try
            {
                if (!File.Exists(RutaArchivo))//eso va en el generar
                {

                    XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);

                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartDocument();

                    writer.WriteStartElement("Cierres");

                    foreach (Cierre cierre in ListaCierre)
                    {
                        writer.WriteStartElement("Cierre");
                        writer.WriteElementString("Fecha", Convert.ToString(cierre.Fecha));
                        writer.WriteStartElement("Usuario");
                        writer.WriteElementString("Nombre", cierre.User.U);
                        writer.WriteElementString("UltimoAcceso", Convert.ToString(cierre.User.UltAcceso));
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cierre> ObtenerCierres()
        {
            List<Cierre> ListaCierres = new List<Cierre>();

            try
            {
                FileStream archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archivo);

                Cierre cierre = null;

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Cierres":
                                break;

                            case "Cierre":
                                cierre = new Cierre();
                                break;

                            case "Fecha":
                                if (reader.Read())
                                {
                                    cierre.Fecha = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "Usuario":
                                cierre.User = new Usuario();
                                break;

                            case "Nombre":
                                if (reader.Read())
                                {
                                    cierre.User.U = reader.Value;
                                }
                                break;

                            case "UltimoAcceso":
                                if (reader.Read())
                                {
                                    cierre.User.UltAcceso = Convert.ToDateTime(reader.Value);
                                }
                                break;
                        }
                    }
                    else
                    {
                        if (reader.Name == "Cierre")
                        {
                            ListaCierres.Add(cierre);
                            cierre = null;
                        }
                    }
                }
                reader.Close();
                archivo.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaCierres;
        }

        public void AgregarXMLCierres (List<Cierre> ListaCierre)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);

                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                writer.WriteStartElement("Cierres");

                foreach (Cierre cierre in ListaCierre)
                {
                    writer.WriteStartElement("Cierre");
                    writer.WriteElementString("Fecha", Convert.ToString(cierre.Fecha));
                    writer.WriteStartElement("Usuario");
                    writer.WriteElementString("Nombre", cierre.User.U);
                    writer.WriteElementString("UltimoAcceso", Convert.ToString(cierre.User.UltAcceso));
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
