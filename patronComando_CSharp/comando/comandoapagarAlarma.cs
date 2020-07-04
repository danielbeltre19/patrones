using System;
using System.Collections.Generic;
using System.Text;

namespace comando
{
    class comandoapagarAlarma:comando
    {
        carro vehiculo;

        public comandoapagarAlarma(carro pAuto)
        {
            vehiculo = pAuto;
        }
        public void ejecutar()
        {
            vehiculo.quitarAlarma();
        }
    }
}
