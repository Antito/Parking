using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Movimiento
    {
        string concepto;
        double importe;
        DateTime fecha;
        bool esIngreso;
        Usuario usuario;
        Cierre cierre;
        Alquiler alquiler;

        public Movimiento()
        {

        }

        

        public Movimiento (string concepto, double importe,DateTime fecha,bool esIngreso,Usuario usuario,Cierre cierre, Alquiler alquiler)
        {
            this.concepto = concepto;
            this.importe = importe;
            this.fecha = fecha;
            this.esIngreso = esIngreso;
            this.usuario = usuario;
            this.cierre = cierre;
            this.alquiler = alquiler;
        }

        public Movimiento(string concepto, double importe, DateTime fecha, bool esIngreso, Usuario usuario, Cierre cierre)
        {
            this.concepto = concepto;
            this.importe = importe;
            this.fecha = fecha;
            this.esIngreso = esIngreso;
            this.usuario = usuario;
            this.cierre = cierre;
            
        }

        /*public override string ToString()
        {
            if (Concepto == "AlquilerHora")
            {
                return "Concepto: " + Concepto + "\tImporte: $" + Importe + "\tUsuario: " + Usuario.U + "\tFecha: " + Fecha + "\tCochera: " + Alquiler.Cochera.Ubicacion + "    Patente: " + Alquiler.Cochera.Vehiculo.Dominio;
            }
            else
            {
                if (Concepto == "AlquilerMensual")
                {
                    AlquilerMensual mensual = Alquiler as AlquilerMensual;
                    return "Concepto: " + Concepto + "\tImporte: $" + Importe + "\tUsuario: " + Usuario.U + "\tFecha: " + Fecha + "\tCochera: " + mensual.Cochera.Ubicacion + "\tTitular: " + mensual.Titular;
                }
            }
            return "Concepto: " + Concepto + "\tImporte: $" + Importe + "\tUsuario: " + Usuario.U + "\tFecha: " + Fecha;
        }*/

        public override string ToString()
        {
            if (Concepto == "AlquilerHora")
            {
                return "Concepto: " + Concepto  + "\tUsuario: " + Usuario.U + "\tFecha: " + Fecha + "\tCochera: " + Alquiler.Cochera.Ubicacion + "\tPatente: " + Alquiler.Cochera.Vehiculo.Dominio + "\tImporte: $" + Importe;
            }
            else
            {
                if (Concepto == "AlquilerMensual")
                {
                    AlquilerMensual mensual = Alquiler as AlquilerMensual;
                    return "Concepto: " + Concepto  + "\tUsuario: " + Usuario.U + "\tFecha: " + Fecha + "\tCochera: " + mensual.Cochera.Ubicacion + "\tTitular: " + mensual.Titular + "\tImporte: $" + Importe;
                }
            }
            return "Concepto: " + Concepto  + "\tUsuario: " + Usuario.U + "\tFecha: " + Fecha + "\tImporte: $" + Importe;
        }

        public string Concepto
        {
            get
            {
                return concepto;
            }

            set
            {
                concepto = value;
            }
        }

        public double Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
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

        public bool EsIngreso
        {
            get
            {
                return esIngreso;
            }

            set
            {
                esIngreso = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public Cierre Cierre
        {
            get
            {
                return cierre;
            }

            set
            {
                cierre = value;
            }
        }

        public Alquiler Alquiler
        {
            get
            {
                return alquiler;
            }

            set
            {
                alquiler = value;
            }
        }
    }
}
