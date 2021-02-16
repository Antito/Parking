using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EstacionamientoTPFinal
{
    public class XMLUsuarios
    {
        private string RutaArchivo = @"C:\Manager\usuarios.xml";

        public void GenerarXMLUsuario(List<Usuario> listausuarios)
        {
            try
            {
                

                    XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null); //preparo el archivo para escritura
                    writer.Formatting = Formatting.Indented; //identa el archivo
                    writer.WriteStartDocument(); //escribe el comienzo
                    writer.WriteStartElement("Usuarios"); //crea etiqueta de arranque (contenedor principal)

                    foreach (Usuario u in listausuarios)
                    {
                        writer.WriteStartElement("User");

                        writer.WriteElementString("Usuario", u.U);
                        writer.WriteElementString("Contraseña", u.Password);
                        writer.WriteElementString("UltimoAcceso", u.UltAcceso.ToString());

                        writer.WriteEndElement();

                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush(); //limpia cache
                    writer.Close();

                if (!File.Exists(RutaArchivo)) 
                {
                    File.Create(RutaArchivo);
                }
            }
    
            

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                FileStream archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read); //preparo archivo para lectura

                XmlTextReader reader = new XmlTextReader(archivo);

                Usuario user = null;

                while (reader.Read()) //recorro el archivo
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Usuarios": //etiqueta principal
                                break;
                            case "User":
                                user = new Usuario();
                                break;
                            case "Usuario":
                                if (reader.Read())
                                    user.U = reader.Value;
                                break;
                            case "Contraseña":
                                if (reader.Read())
                                    user.Password = reader.Value;
                                break;
                            case "UltimoAcceso":
                                if (reader.Read())
                                    user.UltAcceso = Convert.ToDateTime(reader.Value);
                                break;

                        }
                    }
                    else
                    {
                        if (reader.Name == "User")
                        {
                            usuarios.Add(user);
                            user = null;
                        }
                    }
                } //cierre while


            reader.Close(); //Cerramos el Reader. IMPORTANTE
            archivo.Close(); //Cerramos el Archivo. IMPORTANTE

        } // cierre try 
            catch (Exception ex)
            {
                throw ex;
            }

            return usuarios;
        }

    }
}
