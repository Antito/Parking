using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoTPFinal
{
    public class Vehiculo
    {
        string dominio;
        string marca;
        string modelo;
        TipoVehiculo tipoVehiculo;

        public Vehiculo() { }

        public string Dominio
        {
            get
            {
                return dominio;
            }

            set
            {
                dominio = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public TipoVehiculo TipoVehiculo
        {
            get
            {
                return tipoVehiculo;
            }

            set
            {
                tipoVehiculo = value;
            }
        }

        public Vehiculo (string dominio, string marca, string modelo, TipoVehiculo tipoVehiculo)
        {
            this.dominio = dominio;
            this.marca = marca;
            this.modelo = modelo;
            this.tipoVehiculo = tipoVehiculo;
        }
    }
}
