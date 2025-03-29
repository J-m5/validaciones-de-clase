
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria()); se comenta con control + k + c



Chofer pilot1 = new Chofer("Vicente", 35, "A");
Chofer pilot2 = new Chofer("Lola", 28, "C");
Chofer pilot3 = new Chofer("Pedro", 45, "B");
Chofer pilot4 = new Chofer("Luis", 25, "M");

Console.WriteLine("Moto: ");
Moto honda = new Moto(2021, "Negra", "honda-150");
honda.InformacionVehiculo();

Console.WriteLine(honda.AsignarPiloto(pilot4));
pilot4.MostrarInformación();
pilot4.MostrarValidacion();

honda.Encender();
honda.acelerar(150);
honda.HacerCaballito();
honda.Frenar(50);
honda.acelerar(180);
honda.Frenar(50);
honda.Frenar(20);
honda.HacerCaballito();
honda.Apagar();


Console.WriteLine("camioneta: ");
camioneta acuramdx = new camioneta(2025, "girs cormada", "Honda");
acuramdx.InformacionVehiculo();
acuramdx.verCantidadPasajeros();

Console.WriteLine(acuramdx.AsignarPiloto(pilot4));
pilot4.MostrarInformación();
pilot4.MostrarValidacion();
Console.WriteLine(acuramdx.AsignarPiloto(pilot2));
pilot2.MostrarInformación();
pilot2.MostrarValidacion();

acuramdx.Encender();
acuramdx.acelerar(100);
acuramdx.Frenar(10);
acuramdx.Apagar();
acuramdx.acelerar(160);
acuramdx.Frenar(80);
acuramdx.Apagar();


Console.WriteLine("minibus:");
minibus neitor = new minibus(2020, "azul marino", "Ford");
neitor.InformacionVehiculo();
neitor.VerCantidadAsientos();

Console.WriteLine(neitor.AsignarPiloto(pilot1));
pilot1.MostrarInformación();
pilot1.MostrarValidacion();

neitor.Encender();
neitor.acelerar(80);
neitor.Frenar(10);
neitor.acelerar(100);
neitor.Frenar(20);
Console.WriteLine("muy rapido maneja");
neitor.Apagar();




//Console.WriteLine("LICENCIA TIPO B ");
//Taxi retinto = new Taxi(2026, "Corinto", "Toyota");
//Console.WriteLine(retinto.AsignarPiloto(pilot3));
//retinto.verCantidadPasajeros();

//Console.WriteLine(" ");

//Console.WriteLine("LICENCIA TIPO A ");
//autoBus bus = new autoBus(2015, "Azul y Blanco", "Toyota");
//Console.WriteLine(bus.AsignarPiloto(pilot1));
//bus.verCantidadAscientos();


//Console.WriteLine("Pilotos 1:");
//pilot1.MostrarInformación();
//Console.WriteLine("Pilotos 2:");
//pilot2.MostrarInformación();
//Console.WriteLine("Pilotos 3:");
//pilot3.MostrarInformación();

//Vehiculo sedan = new Vehiculo(2026, "Azul", "Toyota");

//Console.WriteLine(sedan.Encender());
//sedan.acelerar(10);
//Console.WriteLine(sedan.AsignarPiloto(pilot1));
//Console.WriteLine(sedan.Encender());
//sedan.acelerar(10);

//string respuesta = sedan.AsignarPiloto(pilot3);
//Console.WriteLine(respuesta);

//Moto honda = new Moto(2026, "Negra", "Honda");
//Console.WriteLine(honda.AsignarPiloto(pilot1));





