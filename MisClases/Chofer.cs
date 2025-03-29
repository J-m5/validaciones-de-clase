using p1bpoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Chofer : Ipiloto 
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        string Ipiloto.Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Ipiloto.Edad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Ipiloto.TipoLicencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Chofer(string name, int edadPiloto, string tipo)
        {
           Nombre = name;
           Edad = edadPiloto;
           TipoLicencia = tipo;
        }

        public bool ValidarLicencia()
        {
            switch(TipoLicencia.ToUpper())
            {
                case "A":
                    return Edad >= 23; // Licencia Tipo A requiere una edad  mínima de 18 años
                case "B":
                    return Edad >= 21; // Licencia Tipo B requiere una edad  minima de 18 años
                case "C":
                    return Edad >= 16; // Licencia Tipo C requiere de  21 años
                case "D":
                    return Edad >= 16;  // Licencia Tipo D requiere de 21 años
                default:
                    return false; // Si el tipo de licencia no es válido

            }
        }

        public void MostrarValidacion()
        {
            if (ValidarLicencia())
            {
                Console.WriteLine($"{Nombre} tiene la edad necesaria para obtener la licencia tipo {TipoLicencia} y conducir este vehiculo.");


            }
            else
            {
                Console.WriteLine($"{Nombre} lamentablemete no tiene la edad necesaria  para obtener la licencia {TipoLicencia}.");

            }

        }

        public void MostrarInformación()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("edad: {0}", this.Edad);
            Console.WriteLine("Licencia Tipo: {0}", this.TipoLicencia);
        }
    }
}
