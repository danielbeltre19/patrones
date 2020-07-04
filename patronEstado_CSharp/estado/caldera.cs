using System;
using System.Collections.Generic;
using System.Text;

namespace estado
{
    class caldera
    {
        private estado calentando;
        private estado alarma;
        private estado espera;

        private estado estado;
        private int temperatura;
        private int combustible;



        public int Temperatura { get => temperatura; set => temperatura = value; }
        public int Combustible { get => combustible; set => combustible = value; }
        internal estado Calentado { get => calentando; set => calentando = value; }
        internal estado Alarma { get => alarma; set => alarma = value; }
        internal estado Espera { get => espera; set => espera= value; }

        public caldera()
        {
            temperatura = 20;
            combustible = 50;

            calentando = new estadoCalentando(this);
            alarma = new estadoAlarma(this);
            espera = new estadoEspera(this);

            estado = calentando;
        }

        public void colocarEstado(estado pEstado)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----Cambio de Estado----");
            estado = pEstado;
        }
        public void trabajar()
        {
            estado.trabajar();
        }
        public void cortaFuego()
        {
            estado.cortaFuego();
        }
        public void ponerCombustible()
        {
            estado.ponerCombustible();
        }
        public void forzarFuego()
        {
            estado.forzarFuego();
        }
        public override string ToString()
        {
            return estado.ToString();
        }
    }
}
