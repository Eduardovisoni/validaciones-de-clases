using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class chofer : iPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }
        public int EdadMinima { get; set; }
        public chofer(string nombre, int edad, string tipoLicencia, string tipoVehiculo) //Constructor
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoLicencia = tipoLicencia;
            if (!ValidarEdad(edad, tipoLicencia))
            {
                if (tipoVehiculo == "moto")
                {
                    Console.WriteLine("La edad no es válida para el tipo de licencia para la moto\n");
                }
                else if (tipoVehiculo == "furgon")
                {
                    Console.WriteLine("La edad no es válida para el tipo de licencia para el furgon\n");
                }
                else if (tipoVehiculo == "panel")
                {
                    Console.WriteLine("La edad no es válida para el tipo de licencia para el panel\n");
                }
                else
                {
                    Console.WriteLine("La edad no es válida para el tipo de licencia.");
                }
            }
        }

        private bool ValidarEdad(int edad, string tipoLicencia)
        {
            switch (tipoLicencia.ToUpper())
            {
                case "A":
                    return edad >= 23;
                case "B":
                    return edad >= 21;
                case "C":
                    return edad >= 18;
                case "M":
                    return edad >= 18;
                case "E":
                    return edad >= 18;
                default:
                    return false; // Licencia inválida
            }
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("Edad: {0}", this.Edad);
            Console.WriteLine("Tipo de licencia: {0}", this.TipoLicencia);
        }
    }
}
