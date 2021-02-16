using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class AlquilerHora : Alquiler
    {
        DateTime desde;
        DateTime hasta;

        public AlquilerHora(DateTime fecha, Cochera cochera, DateTime desde, DateTime hasta) : base(fecha, cochera)
        {
            this.desde = desde;
            this.hasta = hasta;
        }

        public AlquilerHora() { }

        public DateTime Desde
        {
            get
            {
                return desde;
            }

            set
            {
                desde = value;
            }
        }

        public DateTime Hasta
        {
            get
            {
                return hasta;
            }

            set
            {
                hasta = value;
            }
        }
        
        public override double CalcularImporte() 
        {
            /* int thora = (hasta - desde).Hours;

             double resultado = 0;
             /*if(thora <= 1)
             {
                 resultado = 20;
             }else
             {
                 resultado = thora * 20;
             }
             return resultado;



             switch (Cochera.Vehiculo.TipoVehiculo.Descripcion)
             {
                 case "Moto":
                     if (thora < 1)
                     {
                         resultado = 20;
                     }
                     else
                     {
                         resultado = 40 * thora;
                     }
                     break;

                 case "Auto":
                     if (thora < 1)
                     {
                         resultado = 40;
                     }
                     else
                     {
                         resultado = 80 * thora;
                     }
                     break;

                 case "Camioneta":
                     if (thora < 1)
                     {
                         resultado = (120 * thora)+60;
                     }
                     else
                     {
                         resultado = 120 * thora;
                     }
                     break;
             }
             return resultado;

             */

            TimeSpan fecha = hasta - desde; //saca la fecha (horas y minutos)
            int tiempoHora = Convert.ToInt32(fecha.TotalHours); 
            int minutos = Convert.ToInt32(fecha.Minutes);

            double valor = 0;
            double preciosegunvehiculo = 0;
            switch (Cochera.Vehiculo.TipoVehiculo.Codigo)
            {
                case "2":
                    preciosegunvehiculo = 80;
                    break;

                case "3":
                    preciosegunvehiculo = 120;
                    break;

                case "1":
                    preciosegunvehiculo = 40;
                    break;
            }

            if (minutos < 30)
            {

                valor = (tiempoHora * preciosegunvehiculo) + (preciosegunvehiculo / 2);

            }
            else
            {


                valor = tiempoHora * preciosegunvehiculo;
            }
            return valor;
            

        }
    }
}
