using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LaboratorioProgra1.Laboratorio;


namespace LaboratorioProgra1.ChildClasses
{
    internal class JuegoAccion: VideoJuego
    {
        private string? armaInicial;
        private string? armaduraInicial;
        private bool incluyeDLC;

        public string ArmaInicial
        {
            get { return armaInicial; }
            set { armaInicial = value; }
        }

        public string ArmaduraInicial
        {
            get { return armaduraInicial; }
            set { armaduraInicial = value; }
        }

        public bool IncluyeDLC
        {
            get { return incluyeDLC; }
            set { incluyeDLC = value; }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Arma Inicial: {armaInicial}");
            Console.WriteLine($"Armadura Inicial: {armaduraInicial}");
            Console.WriteLine($"Incluye DLC: {incluyeDLC}");
        }

        public void Disparar()
        {
            Console.WriteLine("¡Bang! ¡Bang! ¡Bang!");
        }

        public void Correr()
        {
            Console.WriteLine("¡El personaje empezo a correr!");
        }

        public void Curarse()
        {
            Console.WriteLine("¡El personaje se ha curado!");
        }
    }
}
