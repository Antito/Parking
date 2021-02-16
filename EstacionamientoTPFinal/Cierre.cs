using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Cierre
    {
        DateTime fecha;
        Usuario user; //nombre usuario, pass y ultimo acceso

        public Cierre()
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

        public Usuario User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public Cierre (DateTime fecha,Usuario user)
        {
            this.fecha = fecha;
            this.user = user;
        }

        public override string ToString()
        {
            return "Usuario: " + User.U +" "+ "Fecha: " + Fecha;
        }
    }
}
