using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class nitrogeno : componentes
    {

        private componentes decoramosA;

        public nitrogeno(componentes pComponentes)
        {
            decoramosA = pComponentes;
        }
        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 45000 ;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo";
        }
        public void usaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
