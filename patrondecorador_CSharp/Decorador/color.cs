using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class color:componentes
    {
        private componentes decoramosA;

        public color(componentes pComponentes)
        {
            decoramosA = pComponentes;
        }

        public override string ToString()
        {
            return "Pinura de buena Calidad  \r\n" + decoramosA.ToString();

        }

        public double Costo()
        {
            return decoramosA.Costo() + 10500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Color Aplicado";
        }
    }
}
