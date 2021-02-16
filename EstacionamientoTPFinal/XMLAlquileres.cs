using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EstacionamientoTPFinal
{
    public class XMLAlquileres
    {
        private string RutaArchivo = @"C:\Manager\alquileres.xml";
        Alquileres listaalquiler = new Alquileres();

        public void GenerarXMLAlquileres(List<Alquiler> ListaAlquileres)
        {
            try
            {
                if (!File.Exists(RutaArchivo))//eso va en el generar
                {
                    //codigo de generar
                    XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);

                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartDocument();

                    writer.WriteStartElement("Alquileres");

                    foreach (Alquiler alquiler in ListaAlquileres)
                    {
                        if (alquiler is AlquilerHora)
                        {
                            AlquilerHora PorHora = alquiler as AlquilerHora;
                            writer.WriteStartElement("AlquilerHora");
                            writer.WriteElementString("Fecha", Convert.ToString(PorHora.Fecha));
                            writer.WriteElementString("HoraIngreso", Convert.ToString(PorHora.Desde));
                            writer.WriteElementString("HoraEgreso", Convert.ToString(PorHora.Hasta));
                            writer.WriteStartElement("Cochera");
                            writer.WriteElementString("Numero", Convert.ToString(PorHora.Cochera.Numero));
                            writer.WriteElementString("Ubicacion", PorHora.Cochera.Ubicacion);
                            writer.WriteElementString("Estado", Convert.ToString(PorHora.Cochera.Estado));
                            writer.WriteStartElement("Vehiculo");
                            writer.WriteElementString("Dominio", PorHora.Cochera.Vehiculo.Dominio);
                            writer.WriteElementString("Marca", PorHora.Cochera.Vehiculo.Marca);
                            writer.WriteElementString("Modelo", PorHora.Cochera.Vehiculo.Modelo);
                            writer.WriteStartElement("TipoVehiculo");
                            writer.WriteElementString("Codigo", Convert.ToString(PorHora.Cochera.Vehiculo.TipoVehiculo.Codigo));
                            writer.WriteElementString("Descripcion", PorHora.Cochera.Vehiculo.TipoVehiculo.Descripcion);
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                        else
                        {
                            AlquilerMensual Mensual = alquiler as AlquilerMensual;

                            writer.WriteStartElement("AlquilerMensual");
                            writer.WriteElementString("Fecha", Convert.ToString(Mensual.Fecha));
                            writer.WriteElementString("Titular", Mensual.Titular);
                            writer.WriteElementString("FechaVencimiento", Convert.ToString(Mensual.Fechavencimiento));
                            writer.WriteStartElement("Cochera");
                            writer.WriteElementString("Numero", Convert.ToString(Mensual.Cochera.Numero));
                            writer.WriteElementString("Ubicacion", Mensual.Cochera.Ubicacion);
                            writer.WriteElementString("Estado", Convert.ToString(Mensual.Cochera.Estado));
                            writer.WriteStartElement("Vehiculo");
                            writer.WriteElementString("Dominio", Mensual.Cochera.Vehiculo.Dominio);
                            writer.WriteElementString("Marca", Mensual.Cochera.Vehiculo.Marca);
                            writer.WriteElementString("Modelo", Mensual.Cochera.Vehiculo.Modelo);
                            writer.WriteStartElement("TipoVehiculo");
                            writer.WriteElementString("Codigo", Convert.ToString(Mensual.Cochera.Vehiculo.TipoVehiculo.Codigo));
                            writer.WriteElementString("Descripcion", Mensual.Cochera.Vehiculo.TipoVehiculo.Descripcion);
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
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

      public List<Alquiler> ObtenerAlquileres ()
        {
            List<Alquiler> ListaAlquileres = new List<Alquiler>();

            try
            {
                FileStream archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archivo);

                Alquiler alquiler = null;
                AlquilerHora hora = null;
                AlquilerMensual mes = null;

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Alquileres":
                                break;

                            case "AlquilerHora":
                                alquiler = new AlquilerHora();
                                break;

                            case "AlquilerMensual":
                                alquiler = new AlquilerMensual();
                                break;

                            case "Fecha":
                                if (reader.Read())
                                {
                                    alquiler.Fecha = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "HoraIngreso":
                                if (reader.Read())
                                {
                                    hora = alquiler as AlquilerHora;
                                    hora.Desde = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "HoraEgreso":
                                if (reader.Read())
                                {
                                    hora = alquiler as AlquilerHora;
                                    hora.Hasta = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "Titular":
                                if (reader.Read())
                                {
                                    mes = alquiler as AlquilerMensual;
                                    mes.Titular = reader.Value;
                                }
                                break;

                            case "FechaVencimiento":
                                if (reader.Read())
                                {
                                    mes = alquiler as AlquilerMensual;
                                    mes.Fechavencimiento = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "Cochera":
                                alquiler.Cochera = new Cochera();
                                break;

                            case "Numero":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Numero = Convert.ToInt32(reader.Value);
                                }
                                break;

                            case "Ubicacion":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Ubicacion = reader.Value;
                                }
                                break;

                            case "Estado":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Estado = Convert.ToBoolean(reader.Value);
                                }
                                break;

                            case "Vehiculo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo = new Vehiculo();
                                }
                                break;

                            case "Dominio":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Dominio = reader.Value;
                                }
                                break;

                            case "Marca":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Marca = reader.Value;
                                }
                                break;

                            case "Modelo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Modelo = reader.Value;
                                }
                                break;

                            case "TipoVehiculo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.TipoVehiculo = new TipoVehiculo();
                                }
                                break;

                            case "Codigo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.TipoVehiculo.Codigo = reader.Value;
                                }
                                break;

                            case "Descripcion":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.TipoVehiculo.Descripcion = reader.Value;
                                }
                                break;
                        }
                    }
                    else
                    {
                        if (reader.Name == "AlquilerHora" || reader.Name == "AlquilerMensual")
                        {
                            ListaAlquileres.Add(alquiler);
                            alquiler = null;
                        }
                    }
                }
                reader.Close();
                archivo.Close();
            }

            catch(Exception ex)
            {
                throw ex;
            }
            return ListaAlquileres;

        }


        
        public bool archivovacio()
        {
            try
            {
                FileStream archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                if (archivo.Length == 0)
                {
                    archivo.Close();
                    return true;
                }
                else
                {
                    archivo.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void AgregarAlquilerXML(List<Alquiler> ListaAlquileres)
        {
            try
            {
                
                XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);

                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                writer.WriteStartElement("Alquileres");

                foreach (Alquiler alquiler in ListaAlquileres)
                {
                    if (alquiler is AlquilerHora)
                    {
                        AlquilerHora PorHora = alquiler as AlquilerHora;
                        writer.WriteStartElement("AlquilerHora");
                        writer.WriteElementString("Fecha", Convert.ToString(PorHora.Fecha));
                        writer.WriteElementString("HoraIngreso", Convert.ToString(PorHora.Desde));
                        writer.WriteElementString("HoraEgreso", Convert.ToString(PorHora.Hasta));
                        writer.WriteStartElement("Cochera");
                        writer.WriteElementString("Numero", Convert.ToString(PorHora.Cochera.Numero));
                        writer.WriteElementString("Ubicacion", PorHora.Cochera.Ubicacion);
                        writer.WriteElementString("Estado", Convert.ToString(PorHora.Cochera.Estado));
                        writer.WriteStartElement("Vehiculo");
                        writer.WriteElementString("Dominio", PorHora.Cochera.Vehiculo.Dominio);
                        writer.WriteElementString("Marca", PorHora.Cochera.Vehiculo.Marca);
                        writer.WriteElementString("Modelo", PorHora.Cochera.Vehiculo.Modelo);
                        writer.WriteStartElement("TipoVehiculo");
                        writer.WriteElementString("Codigo", Convert.ToString(PorHora.Cochera.Vehiculo.TipoVehiculo.Codigo));
                        writer.WriteElementString("Descripcion", PorHora.Cochera.Vehiculo.TipoVehiculo.Descripcion);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    else
                    {
                        AlquilerMensual Mensual = alquiler as AlquilerMensual;

                        writer.WriteStartElement("AlquilerMensual");
                        writer.WriteElementString("Fecha", Convert.ToString(Mensual.Fecha));
                        writer.WriteElementString("Titular", Mensual.Titular);
                        writer.WriteElementString("FechaVencimiento", Convert.ToString(Mensual.Fechavencimiento));
                        writer.WriteStartElement("Cochera");
                        writer.WriteElementString("Numero", Convert.ToString(Mensual.Cochera.Numero));
                        writer.WriteElementString("Ubicacion", Mensual.Cochera.Ubicacion);
                        writer.WriteElementString("Estado", Convert.ToString(Mensual.Cochera.Estado));
                        writer.WriteStartElement("Vehiculo");
                        writer.WriteElementString("Dominio", Mensual.Cochera.Vehiculo.Dominio);
                        writer.WriteElementString("Marca", Mensual.Cochera.Vehiculo.Marca);
                        writer.WriteElementString("Modelo", Mensual.Cochera.Vehiculo.Modelo);
                        writer.WriteStartElement("TipoVehiculo");
                        writer.WriteElementString("Codigo", Convert.ToString(Mensual.Cochera.Vehiculo.TipoVehiculo.Codigo));
                        writer.WriteElementString("Descripcion", Mensual.Cochera.Vehiculo.TipoVehiculo.Descripcion);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

                /*if (!File.Exists(RutaArchivo)) //se crea el archivo solo
                {
                    File.Create(RutaArchivo);
                }*/


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

    }
}

