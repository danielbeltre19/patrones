using System;
using System.Collections.Generic;
using System.Text;

namespace comando
{
    class comandoprendeAlarma : comando
    {
        carro vehiculo;

        public comandoprendeAlarma(carro pAuto)
        {
            vehiculo = pAuto;
        }
        public void ejecutar()
        {
            vehiculo.ponerAlarma();
        }
    }
}
