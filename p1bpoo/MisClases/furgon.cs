using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class furgon : Vehiculo
    {
        public string CargaMaxima { get; set; }

        public furgon(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            TiposLicenciaAceptada = new List<string> { "A" };
            this.CargaMaxima = CargaMaxima;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("Carga máxima: {0}", this.CargaMaxima);
        }

        public string sonido()
        {
            if (estadoVehiculo == 1)
            {
                return "El sistema de sonido esta listo para retumbar.";
            }
            else
            {
                return "Con el carro apagado, el sistema de sonido no funciona.";
            }
        }


        //----------Sobreescrituras----------


        public override string Encender()
        {
            if (piloto == null)
            {
                return "No se puede encender el vehiculo sin un piloto asignado";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "Rum Rummmm...";
            }
            return "El carro ya esta encendido";
        }


        //----------Sobreescrituras----------


        public override void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                if (velocidad + cuanto / 2 > VelocidadMaxima)
                {
                    Console.WriteLine("No se puede superar la velocidad de 120Km/Hr");
                    velocidad = VelocidadMaxima;
                }
                else
                {
                    velocidad += cuanto / 2;
                    Console.WriteLine("Vas a {0} Km/Hr", velocidad);
                }
            }
            else
            {
                Console.WriteLine("No se puede acelerar si el furgon esta apagado");
            }
        }


        //----------Sobreescrituras----------


        public override void DefinirCapacidadTanque(int capacidad)
        {
            if (capacidad <= 0)
            {
                Console.WriteLine("Capacidad del tanque inválida.");
                return;
            }
            CapacidadTanque = capacidad;
            Console.WriteLine("Capacidad del tanque definida a: {0} litros", CapacidadTanque);
        }


        //----------Sobreescrituras----------


        public override double CalcularConsumoCombustible(int km)
        {
            double consumo = km * ConsumoCombustible;
            return consumo;
        }
    }
}
