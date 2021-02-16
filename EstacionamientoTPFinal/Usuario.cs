using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Usuario
    {
        string u;  //nombre de usuario 
        string password;
        DateTime ultAcceso;

        public string U
        {
            get
            {
                return u;
            }

            set
            {
                u = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public DateTime UltAcceso
        {
            get
            {
                return ultAcceso;
            }

            set
            {
                ultAcceso = value;
            }
        }

        public Usuario (string u, string password, DateTime ultAcceso)
        {
            this.u = u;
            this.password = password;
            this.ultAcceso = ultAcceso;
        }

        public Usuario()
        {
        }
    }
}
