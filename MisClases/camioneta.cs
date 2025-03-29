using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class camioneta : Vehiculo
    {
        private int cantidadPasajeros = 4;
        public camioneta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "B" };
        }

        protected override int VelocidadMaxima { get; set; } = 220;
        protected override int CapacidadTanque { get; set; } = 10;
        protected override double ConsumoCombustible { get; set; } = 8.8;

        public void verCantidadPasajeros()
        {
            Console.WriteLine("Cantidad de pasajeros: {0}", cantidadPasajeros);
        }

        // Nuevo método para cambiar la cantidad de pasajeros
        public void cambiarCantidadPasajeros(int nuevaCantidad)
        {
            if (nuevaCantidad > 0 && nuevaCantidad <= 8)
            {
                cantidadPasajeros = nuevaCantidad;
                Console.WriteLine("Cantidad de pasajeros actualizada a: {0}", cantidadPasajeros);
            }
            else
            {
                Console.WriteLine("Cantidad de pasajeros no válida. Debe estar entre 1 y 8.");
            }
        }
       

        public override void acelerar(int cuanto)
        {
            if (velocidad + cuanto <= VelocidadMaxima)
            {
                velocidad += cuanto;
                Console.WriteLine("La camioneta ha acelerado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede exceder la velocidad máxima de {0} km/h.", VelocidadMaxima);
            }
        }

        public override void Frenar(int cuanto)
        {
            if (velocidad - cuanto >= 0)
            {
                velocidad -= cuanto;
                Console.WriteLine("La camioneta ha frenado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede frenar más, la camioneta está detenida.");
            }
        }

        public override string TipoLicencia()
        {
            return "Licencia tipo B requerida para conducir la camioneta.";
        }

    }
}
