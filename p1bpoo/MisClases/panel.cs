using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class panel : Vehiculo
    {
        public string Pasajeros { get; set; }
        public panel(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            TiposLicenciaAceptada = new List<string> {"B"};
            this.Pasajeros = Pasajeros;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("Pasajeros: {0}", this.Pasajeros);
        }

        public string puertaAutomatica()
        {
            if (estadoVehiculo == 1)
            {
                return "Las puertas se cerraron automáticamente.";
            }
            else
            {
                return "Con el carro apagado, las puertas se cierran manualmente.";
            }
        }

        public string aireAcondicionado()
        {
            if (estadoVehiculo == 1)
            {
                return "El aire acondicionado esta listo para enfriar.";
            }
            else
            {
                return "Con el carro apagado, el aire acondicionado no funciona.";
            }
        }


        //----------Sobreescrituras----------


        public override void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                if (velocidad + cuanto > VelocidadMaxima)
                {
                    Console.WriteLine("Si pasas de 120 KM/HR las cajas de pan que llevamos, se caeran!");
                    velocidad = VelocidadMaxima;
                }
                else
                {
                    velocidad += cuanto;
                    Console.WriteLine("Vamos a {0} Km/Hr", velocidad);
                }
            }
            else
            {
                Console.WriteLine("No se puede acelerar si el carro esta apagado");
            }
        }


        //----------Sobreescrituras----------


        public override void DefinirCapacidadTanque(int capacidad)
        {
            if (capacidad <= 0)
            {
                Console.WriteLine("Estas bromeando vrdd? No puedes poner esa capacidad en el tanque");
                return;
            }
            if (capacidad >= 100)
            {
                Console.WriteLine("Te pasas wey, no puedes poner un tanque de esa capacidad!!");
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
