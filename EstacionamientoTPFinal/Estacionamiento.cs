using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamientoTPFinal
{
    public class Estacionamiento
    {
        string nombre;

        

        public Estacionamiento ()
        {
            this.nombre="Parking";
        }

        List<Cochera> ListaCocheras = new List<Cochera>();

        public IEnumerable<Button> Controls { get; internal set; }

        public Cochera BuscarCochera(int numero)
        {
            Cochera cochera = null;
            foreach(Cochera aux in ListaCocheras)
            {
                if (numero == aux.Numero)
                {
                    cochera = aux;
                }
                
            }
            return cochera;
        }

        public void AgregarCochera(Cochera c)
        {
            ListaCocheras.Add(c);
        }

        public Cochera DevolverCochera (string ubicacion)
        {
            bool encontro = false;
            Cochera aux =null;
            while (encontro == false)
            {
                foreach (Cochera cochera in ListaCocheras)
                {
                    if (cochera.Ubicacion == ubicacion)
                    {
                        encontro = true;
                        aux= cochera;
                        
                    }
                }
            }
            return aux;
        }

        public List<Cochera> DevolverTodos ()
        {
            return ListaCocheras;
        }

        public void EliminarCochera(Cochera c)
        {
            
            ListaCocheras.Remove(c);
      
        }

        public void AgregarCocherasenLote(List<Cochera> cocheras)
        {
            //this.ListaCocheras = cocheras;

            foreach (Cochera aux in cocheras)
                ListaCocheras.Add(aux);
        }
    }
}
