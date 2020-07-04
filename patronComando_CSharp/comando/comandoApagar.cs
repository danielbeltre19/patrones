using System;
using System.Collections.Generic;
using System.Text;

namespace comando
{
    class comandoApagar : comando
    {
        carro vehiculo;

        public comandoApagar(carro pAuto)
        {
            vehiculo=pAuto;
        }

        public void ejecutar()
        {
            vehiculo.apagar();
        }
    }
}
