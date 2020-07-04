using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class suspension : componentes
    {
        private componentes decoramosA;

        public suspension(componentes pComponentes)
        {
            decoramosA = pComponentes;
        }

        public override string ToString()
        {
            return "Suspencion de alto desempeño \r\n" + decoramosA.ToString();

        }

        public double Costo()
        {
            return decoramosA.Costo() + 70845;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Elevando Suspension";
        }
    }
}
