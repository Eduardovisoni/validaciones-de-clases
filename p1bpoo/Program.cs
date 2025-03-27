
using p1bpoo.MisClases;

chofer pilot1 = new chofer("Juan", 18, "M", "moto"); //La edad minima es: 18
chofer pilot2 = new chofer("Marcos", 21, "B", "panel"); //La edad minima es: 21
chofer pilot3 = new chofer("Maria", 23, "A", "furgon"); //La edad minima es: 23


//moto honda = new moto(2025, "Azul", "Honda");
//Console.WriteLine("Moto");
//Console.WriteLine(honda.AsignarPiloto(pilot1));
//honda.Encender();
//honda.acelerar(60); //Velocidad maxima 120 km/h
//honda.HacerCaballito();
//honda.DefinirCapacidadTanque(18); //Capacidad del tanque 
//double consumoMoto = honda.CalcularConsumoCombustible(60); //Consumo de combustible
//Console.WriteLine("Consumo de combustible para km asignados: {0} litros", consumoMoto);

furgon furgon1 = new furgon(2025, "Verde", "Toyota");
Console.WriteLine("\nFurgon");
furgon1.CargaMaxima = "20kg";
furgon1.mostrarInformacion();
Console.WriteLine(furgon1.AsignarPiloto(pilot3));
Console.WriteLine("Encendiendo Motor: " +furgon1.Encender());

Console.WriteLine(furgon1.sonido());
furgon1.acelerar(60); //Velocidad Maxima 120km/h
furgon1.DefinirCapacidadTanque(50); //Capacidad del tanque
double consumoFurgon = furgon1.CalcularConsumoCombustible(60); //Consumo de combustible
Console.WriteLine("Consumo de combustible para km asignados: {0} litros", consumoFurgon);



panel panel1 = new panel(2025, "Blanco", "Toyota");
Console.WriteLine("\nPanel");
panel1.Pasajeros = "5";
panel1.mostrarInformacion();
Console.WriteLine(panel1.AsignarPiloto(pilot2));
Console.WriteLine("Encendiendo Motor: " + panel1.Encender());

Console.WriteLine(panel1.puertaAutomatica());
Console.WriteLine(panel1.aireAcondicionado());
panel1.acelerar(121); //Velocidad Maxima 120km/h
panel1.DefinirCapacidadTanque(80); //Capacidad del tanque
double consumoPanel = panel1.CalcularConsumoCombustible(150); //Consumo de combustible
Console.WriteLine("Con esa cantidad de Km el furgon consume {0} litros, bastante no?", consumoPanel);

//CarroElectrico tesla = new CarroElectrico(2025, "Gris", "Model Y Juniper");
//Console.WriteLine("\nCarro Electrico");
//Console.WriteLine(tesla.AsignarPiloto(pilot2));
//Console.WriteLine("Encendiendo Motor: " + tesla.Encender());
//tesla.acelerar(60); //Velocidad Maxima 120km/h
//tesla.DefinirCapacidadTanque(100); //Capacidad del tanque
//double consumoTesla = tesla.CalcularConsumoCombustible(20); //Consumo de combustible




Console.WriteLine("\n--------------------------------\n");

Vehiculo sedan = new Vehiculo(2025, "Rojo", "Toyota");
sedan.AsignarPiloto(pilot2);
sedan.DefinirCapacidadTanque(50);
double consumo = sedan.CalcularConsumoCombustible(60);
Console.WriteLine("Consumo de combustible para km asignados: {0} litros", consumo);
Console.WriteLine(sedan.Encender());
sedan.acelerar(0);

sedan.InformacionVehiculo();

sedan.Frenar(0);
Console.WriteLine(sedan.Apagar());




//Console.WriteLine(sedan.AsignarPiloto(pilot1));
//Console.WriteLine(sedan.Encender());
//sedan.acelerar(15);

//string respuesta = sedan.AsignarPiloto(pilot1);
//Console.WriteLine("\n" +respuesta);




