using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProgra1.Laboratorio;

namespace LaboratorioProgra1.ChildClasses
{
    internal class JuegoAventura : VideoJuego
    {
        private string[] regiones;
        private int cantidadDeMisiones;
        private bool mundoAbierto;

        public string[] Regiones
        {
            get { return regiones; }
            set { regiones = value; }
        }
        public int CantidadDeMisiones
        {
            get { return cantidadDeMisiones; }
            set { cantidadDeMisiones = value; }
        }
        public bool MundoAbierto
        {
            get { return mundoAbierto; }
            set { mundoAbierto = value; }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Regiones:");
            foreach (string region in regiones)
            {
                Console.WriteLine(region);
            }
            Console.WriteLine($"Cantidad de Misiones: {cantidadDeMisiones}");
            Console.WriteLine($"Mundo Abierto: {mundoAbierto}");
        }

        public void Luchar()
        {
            Console.WriteLine("¡El personaje ha comenzado a luchar!");
        }

        public void Saltar()
        {
            Console.WriteLine("¡El personaje ha saltado!");
        }

        public void abrirCofre()
        {
            Console.WriteLine("¡El personaje ha abierto un cofre!");
        }

    }
}
