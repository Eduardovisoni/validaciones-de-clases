using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }


        //----------Sobreescrituras----------


        public override void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                int incremento = cuanto * 2;
                if (velocidad + incremento > VelocidadMaxima)
                {
                    Console.WriteLine("¡Alerta! No se puede superar la velocidad máxima de 120 KM/HR");
                    velocidad = VelocidadMaxima;
                }
                else
                {
                    velocidad += incremento;
                    Console.WriteLine("Velocidad actual: {0}", velocidad);
                }
                cargaBateria -= incremento;
                if (cargaBateria < 0) cargaBateria = 0;
                Console.WriteLine("Nivel de batería: {0}%", cargaBateria);
            }
            else
            {
                Console.WriteLine("No se puede acelerar si el carro está apagado");
            }
        }


        //----------Sobreescrituras----------


        public override void DefinirCapacidadTanque(int capacidad)
        {
            Console.WriteLine("Este vehículo no usa tanque de combustible.");
        }


        //----------Sobreescrituras----------


        public override double CalcularConsumoCombustible(int km)
        {
            Console.WriteLine("Este vehículo no usa combustible.");
            return 0;
        }


        //----------Metodos----------


        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria = 100;
            Console.WriteLine("Batería recargada al 100%");
        }

    }
}
