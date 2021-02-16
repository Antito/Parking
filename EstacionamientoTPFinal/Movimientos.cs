using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Movimientos
    {
        List<Movimiento> ListaMovimientos = new List<Movimiento>();

        public Movimiento BuscarMovimiento(Usuario usu)
        {
            Movimiento mov = null;
            foreach (Movimiento aux in ListaMovimientos)
            {
                if (aux.Usuario.U == usu.U)
                {
                    mov= aux;
                }
            }
            return mov;
        }


        public void AgregarMovimientos(Movimiento mov)
        {
            ListaMovimientos.Add(mov);
        }

        public List<Movimiento> MostrarMovimientos()
        {
            return ListaMovimientos;
        }

        public void EliminarMovimiento(Movimiento mov)
        {
            Movimiento m = null;
            m = BuscarMovimiento(mov.Usuario); //tengo dudas
            ListaMovimientos.Remove(mov);
            

        }

        public void AgregarMovimientosenLote(List<Movimiento> movimientos)
        {


            foreach (Movimiento aux in movimientos)
                ListaMovimientos.Add(aux);
        }

        public List<Movimiento> Ingresos() //esto es para que agregue el ingreso en el listBox
        {
            List<Movimiento> ingresos = new List<Movimiento>();

            foreach (Movimiento aux in ListaMovimientos)
            {
                if (aux.EsIngreso == true && aux.Cierre == null)
                {
                    ingresos.Add(aux);
                }
            }
            return ingresos;
        }

        public List<Movimiento> Egresos() //esto es para que agregue el egreso en el listBox
        {
            List<Movimiento> egresos = new List<Movimiento>();

            foreach (Movimiento aux in ListaMovimientos)
            {
                if (aux.EsIngreso == false && aux.Cierre == null)
                {
                    egresos.Add(aux);
                }
            }
            return egresos;
        }

        public List<Movimiento> Cierres (string c) //recibe el select value
        {
            List<Movimiento> movCierre = new List<Movimiento>();
            foreach (Movimiento aux in ListaMovimientos)
            {
                if (aux.Cierre != null)
                {

                    if (c == "Usuario: " + aux.Cierre.User.U +" "+ "Fecha: " + aux.Cierre.Fecha) 
                    {
                        movCierre.Add(aux);
                    }
                }
            }
            return movCierre;
        }

        public double DevolverTotalIngreso () //esto es para que muestre el total de los ingresos en caja
        {
            List<Movimiento> mov = new List<Movimiento>();
            mov = Ingresos();
            double total = 0;
            foreach (Movimiento aux in mov)
            {
                total = total + aux.Importe;
            }
            return total;
        }

        public double DevolverTotalEgreso() //esto es para que muestre el total de los egresos en caja
        {
            List<Movimiento> mov = new List<Movimiento>();
            mov = Egresos();
            double total = 0;
            foreach (Movimiento aux in mov)
            {
                total = total + aux.Importe;
            }
            return total;
        }

        public double DevolverTotalCierres(string c)
        {
            double total = 0;
            foreach (Movimiento aux in ListaMovimientos)
            {
                if (aux.Cierre != null) //si ya esta cerrada la caja 
                {
                    if (c == "Usuario: " + aux.Cierre.User.U + " "+ "Fecha: " + aux.Cierre.Fecha)
                    {
                        if (aux.EsIngreso == true)
                        {
                            total = total + aux.Importe;
                        }else
                        {
                            total = total - aux.Importe;
                        }
                    }
                }
            }
            return total;
        }

        /*public double DevolverTotalFacturadoCerrados(string fecha)//utilizado en el historial para mostrar el total facturado de los cierres
        {
            double total = 0;
            foreach(Movimiento auxmove in ListaMovimiento)
            {
                if(auxmove.Cierre!=null)//si ya esta cerrado
                {
                    if (fecha=="Fecha"+auxmove.Fecha.Day+"/"+auxmove.Fecha.Month+"/"+auxmove.Fecha.Year)
                    {
                        //falta chequear si es ingreso o egreso y segun eso sumar o restar
                        if(auxmove.Esingreso==true)
                        {
                            total = total + auxmove.Importe;
                        }
                        else
                        {
                            total = total - auxmove.Importe;

                        }


                        
                    }

                }
                
            }
            return total;
        } */

        public List<Movimiento> IngresosCierre(string c) //esto es para que agregue el listbox en Cierres de Ingresos
        {
            List<Movimiento> ingresos = new List<Movimiento>();

            foreach (Movimiento aux in ListaMovimientos)
            {
                if (aux.EsIngreso == true && aux.Cierre != null)
                {
                    if (c == "Usuario: " + aux.Cierre.User.U + " " + "Fecha: " + aux.Cierre.Fecha)
                    {
                        ingresos.Add(aux);
                    }
                        
                }
            }
            return ingresos;
        }

        public List<Movimiento> EgresosCierres(string c) //esto es para que agregue el egreso en el listBox de cierres
        {
            List<Movimiento> egresos = new List<Movimiento>();

            foreach (Movimiento aux in ListaMovimientos)
            {
                if (aux.EsIngreso == false && aux.Cierre != null)
                {
                    if (c == "Usuario: " + aux.Cierre.User.U + " " + "Fecha: " + aux.Cierre.Fecha)
                    {
                        egresos.Add(aux);
                    }
                    
                }
            }
            return egresos;
        }

        public double DevolverTotalIngresoCierre(string c) //esto es para que muestre el total de los ingresos en cierres
        {
            List<Movimiento> mov = new List<Movimiento>();
            mov = IngresosCierre(c);
            double total = 0;
            foreach (Movimiento aux in mov)
            {
                total = total + aux.Importe;
            }
            return total;
        }

        public double DevolverTotalEgresoCierre(string c) //esto es para que muestre el total de los egresos en cierres
        {
            List<Movimiento> mov = new List<Movimiento>();
            mov = EgresosCierres(c);
            double total = 0;
            foreach (Movimiento aux in mov)
            {
                total = total + aux.Importe;
            }
            return total;
        }
    }
}
