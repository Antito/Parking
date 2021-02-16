using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EstacionamientoTPFinal
{
    public class XMLMovimientos
    {
        private string RutaArchivo = @"C:\Manager\movimientos.xml";
        //private string RutaArchivo = @"C:\Users\Usuario\Desktop\Estacionamiento_System\ArchivosXML\movimientos.xml";

        public void GenerarXMLMovimientos(List<Movimiento> ListaMovimientos)
        {
            try
            {
                if (!File.Exists(RutaArchivo))//eso va en el generar
                {

                    XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);

                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartDocument();

                    writer.WriteStartElement("Movimientos");

                    foreach (Movimiento mov in ListaMovimientos)
                    {
                        writer.WriteStartElement("Movimiento");
                        writer.WriteElementString("Concepto", mov.Concepto);
                        writer.WriteElementString("Importe", Convert.ToString(mov.Importe));
                        writer.WriteElementString("Fecha", Convert.ToString(mov.Fecha));
                        writer.WriteElementString("EsIngreso", Convert.ToString(mov.EsIngreso));

                        writer.WriteStartElement("Usuario");
                        writer.WriteElementString("Nombre", mov.Usuario.U);
                        writer.WriteEndElement();
                        if (mov.Cierre != null)
                        {
                            writer.WriteStartElement("Cierre");
                            writer.WriteElementString("FechaCierre", Convert.ToString(mov.Cierre.Fecha));
                            writer.WriteStartElement("UsuarioCierre"); //nombre del usuario
                            writer.WriteElementString("NombreCierre", mov.Cierre.User.U);
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                        if (mov.Concepto == "AlquilerHora" || mov.Concepto == "AlquilerMensual")
                        {
                            if (mov.Alquiler is AlquilerHora)
                            {
                                AlquilerHora PorHora = mov.Alquiler as AlquilerHora;
                                writer.WriteStartElement("AlquilerHora");
                                writer.WriteElementString("FechaIngreso", Convert.ToString(PorHora.Fecha));
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
                                AlquilerMensual Mensual = mov.Alquiler as AlquilerMensual;

                                writer.WriteStartElement("AlquilerMensual");
                                writer.WriteElementString("FechaIngreso", Convert.ToString(Mensual.Fecha));
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

        public List<Movimiento> ObtenerMovimientos()
        {
            List<Movimiento> ListaMovimientos = new List<Movimiento>();

            try
            {
                FileStream archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archivo);

                Movimiento mov = null;
                AlquilerHora hora = null;
                AlquilerMensual mes = null;

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Movimientos":
                                break;

                            case "Movimiento":
                                mov = new Movimiento();
                                break;

                            case "Concepto":
                                if (reader.Read())
                                {
                                    mov.Concepto = reader.Value;
                                }
                                break;

                            case "Importe":
                                if (reader.Read())
                                {
                                    mov.Importe = Convert.ToDouble(reader.Value);
                                }
                                break;

                            case "Fecha":
                                if (reader.Read())
                                {
                                    mov.Fecha = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "EsIngreso":
                                if (reader.Read())
                                {
                                    mov.EsIngreso = Convert.ToBoolean(reader.Value);
                                }
                                break;

                            case "Usuario":
                                mov.Usuario = new Usuario();
                                break;

                            case "Nombre":
                                if (reader.Read())
                                {
                                    mov.Usuario.U = reader.Value;
                                }
                                break;

                            case "Cierre":
                                mov.Cierre = new Cierre();
                                break;

                            case "FechaCierre":
                                if (reader.Read())
                                {
                                    mov.Cierre.Fecha = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "UsuarioCierre":
                                mov.Cierre.User = new Usuario();
                                break;

                            case "NombreCierre":
                                if (reader.Read())
                                {
                                    mov.Cierre.User.U = reader.Value;
                                }
                                break;

                            case "AlquilerHora":
                                mov.Alquiler = new AlquilerHora();
                                break;

                            case "AlquilerMensual":
                                mov.Alquiler = new AlquilerMensual();
                                break;

                            case "FechaIngreso":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Fecha = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "HoraIngreso":
                                if (reader.Read())
                                {
                                    hora = mov.Alquiler as AlquilerHora;
                                    hora.Desde = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "HoraEgreso":
                                if (reader.Read())
                                {
                                    hora = mov.Alquiler as AlquilerHora;
                                    hora.Hasta = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "Titular":
                                if (reader.Read())
                                {
                                    mes = mov.Alquiler as AlquilerMensual;
                                    mes.Titular = reader.Value;
                                }
                                break;

                            case "FechaVencimiento":
                                if (reader.Read())
                                {
                                    mes = mov.Alquiler as AlquilerMensual;
                                    mes.Fechavencimiento = Convert.ToDateTime(reader.Value);
                                }
                                break;

                            case "Cochera":
                                mov.Alquiler.Cochera = new Cochera();
                                break;

                            case "Numero":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Numero = Convert.ToInt32(reader.Value);
                                }
                                break;

                            case "Ubicacion":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Ubicacion = reader.Value;
                                }
                                break;

                            case "Estado":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Estado = Convert.ToBoolean(reader.Value);
                                }
                                break;

                            case "Vehiculo":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Vehiculo = new Vehiculo();
                                }
                                break;

                            case "Dominio":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Vehiculo.Dominio = reader.Value;
                                }
                                break;

                            case "Marca":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Vehiculo.Marca = reader.Value;
                                }
                                break;

                            case "Modelo":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Vehiculo.Modelo = reader.Value;
                                }
                                break;

                            case "TipoVehiculo":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Vehiculo.TipoVehiculo = new TipoVehiculo();
                                }
                                break;

                            case "Codigo":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Vehiculo.TipoVehiculo.Codigo = reader.Value;
                                }
                                break;

                            case "Descripcion":
                                if (reader.Read())
                                {
                                    mov.Alquiler.Cochera.Vehiculo.TipoVehiculo.Descripcion = reader.Value;
                                }
                                break;
                        }
                    }
                    else
                    {
                        if (reader.Name == "Movimiento")
                        {
                            ListaMovimientos.Add(mov);
                            mov = null;
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

            return ListaMovimientos;
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

        public void AgregarXMLMovimientos (List<Movimiento> ListaMovimientos)
        {
            try
            {

                XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);

                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                writer.WriteStartElement("Movimientos");

                foreach (Movimiento mov in ListaMovimientos)
                {
                    writer.WriteStartElement("Movimiento");
                    writer.WriteElementString("Concepto", mov.Concepto);
                    writer.WriteElementString("Importe", Convert.ToString(mov.Importe));
                    writer.WriteElementString("Fecha", Convert.ToString(mov.Fecha));
                    writer.WriteElementString("EsIngreso", Convert.ToString(mov.EsIngreso));

                    writer.WriteStartElement("Usuario");
                    writer.WriteElementString("Nombre", mov.Usuario.U);
                    writer.WriteEndElement();
                    if (mov.Cierre != null)
                    {
                        writer.WriteStartElement("Cierre");
                        writer.WriteElementString("FechaCierre", Convert.ToString(mov.Cierre.Fecha));
                        writer.WriteStartElement("UsuarioCierre"); //nombre del usuario
                        writer.WriteElementString("NombreCierre", mov.Cierre.User.U);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    if (mov.Concepto == "AlquilerHora" || mov.Concepto == "AlquilerMensual")
                    {
                        if (mov.Alquiler is AlquilerHora)
                        {
                            AlquilerHora PorHora = mov.Alquiler as AlquilerHora;
                            writer.WriteStartElement("AlquilerHora");
                            writer.WriteElementString("FechaIngreso", Convert.ToString(PorHora.Fecha));
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
                            AlquilerMensual Mensual = mov.Alquiler as AlquilerMensual;

                            writer.WriteStartElement("AlquilerMensual");
                            writer.WriteElementString("FechaIngreso", Convert.ToString(Mensual.Fecha));
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
