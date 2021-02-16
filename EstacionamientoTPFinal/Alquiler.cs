using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public abstract class Alquiler
    {
        DateTime fecha;
        Cochera cochera;

        public Alquiler(DateTime fecha, Cochera cochera)
        {
            this.fecha = fecha;
            this.cochera = cochera;
        }

        public Alquiler()
        {

        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Cochera Cochera
        {
            get
            {
                return cochera;
            }

            set
            {
                cochera = value;
            }
        }

        

        public abstract double CalcularImporte();
        


    }
}
