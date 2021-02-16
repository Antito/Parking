using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Cochera
    {
        int numero;
        string ubicacion;
        bool estado;
        Vehiculo vehiculo;

        public Cochera () { }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                ubicacion = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public Vehiculo Vehiculo
        {
            get
            {
                return vehiculo;
            }
            set
            {
                vehiculo = value;
            }
        }

        public Cochera (int numero, string ubicacion,bool estado,Vehiculo vehiculo)
        {
            this.numero = numero;
            this.ubicacion = ubicacion;
            this.estado = estado;
            this.vehiculo = vehiculo;
        }
    }
}
