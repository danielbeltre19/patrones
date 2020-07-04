using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace comando
{
    class comandoEncender : comando
    {
        carro vehiculo;

        public comandoEncender(carro pAuto)
        {
            vehiculo = pAuto;
        }


        public void ejecutar()
        {
            vehiculo.Encender();
        }
    }
   
}
