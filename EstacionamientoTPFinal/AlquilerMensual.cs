using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class AlquilerMensual : Alquiler
    {
        string titular;
        DateTime fechavencimiento;

        public string Titular
        {
            get
            {
                return titular;
            }

            set
            {
                titular = value;
            }
        }

        public DateTime Fechavencimiento
        {
            get
            {
                return fechavencimiento;
            }

            set
            {
                fechavencimiento = value;
            }
        }

        public AlquilerMensual(DateTime fecha,Cochera cochera,string titular,DateTime fechavencimiento) : base(fecha,cochera)
        {
            this.titular = titular;
            this.fechavencimiento = fechavencimiento;
        }

        public AlquilerMensual() { }

        public override double CalcularImporte()
        {
            int valor = 0;
            int tmes =Convert.ToInt32((fechavencimiento - Fecha).TotalDays / 30); //probar esto 
            valor = tmes * 1500;

            return valor;
        }

        public override string ToString()
        {
            return "Cochera: " + Cochera.Ubicacion + "\tDominio: " + Cochera.Vehiculo.Dominio + "\tTitular: " + Titular + "\tFecha de Vencimiento: " + Fechavencimiento;
        }
    }
}
