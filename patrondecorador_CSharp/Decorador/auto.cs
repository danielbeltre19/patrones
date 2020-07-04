using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class auto:componentes
    {
        private string modelo;
        private string caracteristica;
        public double costo;

        public auto(string pModelo,string pCaract,double pCosto)
        {
            modelo = pModelo;
            caracteristica = pCaract;
            costo = pCosto;
        }
        public void puertas(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("puertas cerradas");
            else
                Console.WriteLine("puertas abiertas");
        }
        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristica);
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendio el Motor";
        }
    }
}
