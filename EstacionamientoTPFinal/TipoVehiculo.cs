using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class TipoVehiculo
    {
        string codigo;
        string descripcion;

        public TipoVehiculo () { }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public TipoVehiculo (string codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
    }
}
