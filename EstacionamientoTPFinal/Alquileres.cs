using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Alquileres
    {
        List<Alquiler> ListaAlquileres = new List<Alquiler>();

        public Alquiler BuscarAlquiler(DateTime fecha)
        {
            Alquiler a = null;
            foreach (Alquiler aux in ListaAlquileres)
            {
                if (aux.Fecha == fecha)
                {
                    a = aux;
                }
            }
            return a;
        }


        public void AgregarAlquiler(Alquiler a)
        {
            ListaAlquileres.Add(a);
        }

        public List<Alquiler> MostrarAlquileres ()
        {
            return ListaAlquileres;
        }

        public void EliminarAlquiler(Alquiler a)
        {
            
            ListaAlquileres.Remove(a);

           

        }

        public void AgregarAlquileresenLote(List<Alquiler> alquileres)
        {
            

            foreach (Alquiler aux in alquileres)
                ListaAlquileres.Add(aux);
        }

        public Alquiler BuscarCocheraAlquiler(Cochera c)
        {
            Alquiler a = null;
            foreach (Alquiler aux in ListaAlquileres)
            {
                if (aux.Cochera.Ubicacion == c.Ubicacion)
                {
                    a = aux;
                }
            }
            return a;
        }

        public bool BuscarPatente(string patente)
        {
            foreach (Alquiler alquiler in ListaAlquileres)
            {
                if (alquiler.Cochera.Vehiculo.Dominio == patente)
                {
                    return false; //si la encuentra retorna falso
                }
            }
            return true;
        }

        public int Contar()
        {
            return ListaAlquileres.Count;
        }

        public Alquiler BuscarAlquiler2(Alquiler alqui)

        {
            Alquiler devolver = null;
            foreach (Alquiler aux in ListaAlquileres)
            {
                if (aux.Cochera.Ubicacion == alqui.Cochera.Ubicacion)
                {
                    devolver = aux;
                }
            }
            return devolver;
        }

    }



    }

