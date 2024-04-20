using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProgra1.Laboratorio;

namespace LaboratorioProgra1.ChildClasses
{
    internal class JuegoDeporte : VideoJuego
    {
        private string tipoDeporte;
        private string[] equipos;
        private float duracionPartida;

        public string TipoDeporte
        {
            get { return tipoDeporte; }
            set { tipoDeporte = value; }
        }

        public string[] Equipos
        {
            get { return equipos; }
            set { equipos = value; }
        }

        public float DuracionPartida
        {
            get { return duracionPartida; }
            set { duracionPartida = value; }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Tipo de Deporte: {tipoDeporte}");
            Console.WriteLine($"Equipos:");
            foreach (string equipo in equipos)
            {
                Console.WriteLine(equipo);
            }
            Console.WriteLine($"Duración de la Partida: {duracionPartida}");
        }

        public void PersonalizarCamiseta()
        {
            Console.WriteLine("¡El jugador ha personalizado su camiseta!");
        }

        public void Celebrar()
        {
            Console.WriteLine("¡El jugador ha celebrado!");
        }

        public void seleccionarEquipo()
        {
            Console.WriteLine("¡El jugador ha seleccionado un equipo!");
        }
    }
}
