using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class moto : Vehiculo
    {
        public moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            TiposLicenciaAceptada = new List<string> { "M" };
        }


        //----------Sobreescrituras----------


        public override string Encender()
        {
            if (piloto == null)
            {
                return "No se puede encender la moto sin un piloto asignado";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "Moto encendida";
            }
            return "La moto ya esta encendida";
        }


        //----------Sobreescrituras----------


        public override void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                if (velocidad + cuanto*2 > VelocidadMaxima)
                {
                    Console.WriteLine("Te pasaste de 120 Km/hr, los PMT te siguen!!!");
                    velocidad = VelocidadMaxima;
                }
                else
                {
                    velocidad += cuanto*2;
                    Console.WriteLine("Vas a {0} Km/hr frenale we hay PMT a la vuelta.", velocidad);
                }
            }
            else
            {
                Console.WriteLine("Como pensas acelerar si la moto esta apagada?");
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
            CapacidadTanque = capacidad/2;
            Console.WriteLine("La capacidad del tanque es de {0} litros", CapacidadTanque);
        }


        //----------Sobreescrituras----------


        public override double CalcularConsumoCombustible(int km)
        {
            double consumo = km * ConsumoCombustible;
            return consumo;
        }


        //----------Metodos----------


        public void HacerCaballito()
        {
            if (estadoVehiculo == 1)
            {
                Console.WriteLine("¡Estás haciendo un caballito!");
            }
            else
            {
                Console.WriteLine("No puedes hacer un caballito si la moto está apagada.");
            }
        }
    }
}