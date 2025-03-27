using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; set; }
        protected int VelocidadMaxima { get; set; } = 120;
        protected int velocidad = 0;
        protected int CapacidadTanque { get; set; }
        protected int NivelCombustible { get; set; }
        protected double ConsumoCombustible { get; set; } = 0.1;

        protected List<string> TiposLicenciaAceptada = new List<string> { "A", "B", "C", "M", "E" };
        protected chofer piloto = null;
        protected int estadoVehiculo = 0; //0 = apagado, 1 = encendido, 2 = en movimiento

        protected bool encendido = false;

        public string AsignarPiloto(chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!TiposLicenciaAceptada.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene la licencia adecuada";
            }
            if (piloto != null)
            {
                return "El vehiculo ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado exitosamente";
        }
        public virtual string Encender()
        {
            if (piloto == null) {
                return "No se puede encender el vehiculo sin un piloto asignado";
            }
            if (estadoVehiculo == 0) {
                estadoVehiculo = 1;
                return "Vehiculo encendido";
            }
            return "El carro ya esta encendido";

        }
        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }
        public void InformacionVehiculo()
        {
            Console.WriteLine("\nColor: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
            Console.WriteLine("Velocidad actual: {0}", this.velocidad);
            Console.WriteLine("Velocidad maxima: {0}", VelocidadMaxima);
            Console.WriteLine("Estado del vehículo: {0}", ObtenerEstadoVehiculo());
            Console.WriteLine("Piloto asignado: {0}\n", piloto != null ? piloto.Nombre : "Ninguno");
        }
        private string ObtenerEstadoVehiculo()
        {
            return estadoVehiculo switch
            {
                0 => "apagado",
                1 => "encendido",
                2 => "en movimiento",
                _ => "desconocido",
            };
        }
        public virtual void DefinirCapacidadTanque(int capacidad)
        {
            if (capacidad <= 0)
            {
                Console.WriteLine("Capacidad del tanque inválida.");
                return;
            }
            CapacidadTanque = capacidad;
            Console.WriteLine("Capacidad del tanque definida a: {0} litros", CapacidadTanque);
        }
        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                if (velocidad + cuanto > VelocidadMaxima)
                {
                    Console.WriteLine("¡Alerta! No se puede superar la velocidad máxima de 120 KM/HR");
                    velocidad = VelocidadMaxima;
                }
                else
                {
                    velocidad += cuanto;
                    Console.WriteLine("Velocidad actual: {0}", velocidad);
                }
            }
            else
            {
                Console.WriteLine("No se puede acelerar si el carro esta apagado");
            }
        }
        public void Frenar(int cuanto)
        {
            if (estadoVehiculo == 1 || estadoVehiculo == 2)
            {
                velocidad -= cuanto;
                if (velocidad <= 0)
                {
                    velocidad = 0;
                    estadoVehiculo = 1;
                }
                Console.WriteLine("Velocidad actual: {0} KM/H", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede frenar si el carro está apagado");
            }
        }

        public string Apagar()
        {
            if (velocidad == 0)
            {
                estadoVehiculo = 0;
                return "Vehículo apagado";
            }
            else
            {
                return "No se puede apagar el vehículo en movimiento.";
            }
        }
        public virtual double CalcularConsumoCombustible(int km)
        {
            double consumo = km * ConsumoCombustible;
            return consumo;
        }
    }
}
