using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    interface Interface1
    {
       
        void AgregarAlquilerInterfaz(Alquiler alquiler); //hace nexo entre principal y agregar alquiler, agrega lo de listaalquileres de principal a agregar alquiler
        void BorrarAlquilerInterfaz(Alquiler alquiler);
        void AgregarMovimientoInterfaz(Movimiento movimiento);
        void AgregarCierreInterfaz(Cierre cierre);
        void RenovarAlquiler(Movimiento movimiento);
        
    }
}
