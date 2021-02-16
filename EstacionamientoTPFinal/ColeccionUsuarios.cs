using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class ColeccionUsuarios
    {
        List<Usuario> usuarios = new List<Usuario>();

        public void AgregarUsuario(Usuario a)
        {
            usuarios.Add(a);
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }
    }
}
