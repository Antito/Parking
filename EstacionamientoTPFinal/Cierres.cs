using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Cierres
    {
        List<Cierre> ListaCierres = new List<Cierre>();

        public void AgregarCierre(Cierre c)
        {
            ListaCierres.Add(c);
        }

        public List<Cierre> ListarCierres ()
        {
            return ListaCierres;
        }

        public void AgregarCierresEnLotes(List<Cierre> cierres)
        {


            foreach (Cierre aux in cierres)
                ListaCierres.Add(aux);
        }

    }
}
