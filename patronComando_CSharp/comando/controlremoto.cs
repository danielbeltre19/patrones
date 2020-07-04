using System;
using System.Collections.Generic;
using System.Text;

namespace comando
{
    class controlremoto
    {
        private comando[] comandos = new comando[4];

        public controlremoto(carro pAuto)
        {
            comandos[0] = new comandoEncender(pAuto);
            comandos[1] = new comandoApagar(pAuto);
            comandos[2] = new comandoprendeAlarma(pAuto);
            comandos[3] = new comandoapagarAlarma(pAuto);
        }

        public  void boton(int indice)
        {
            comandos[indice].ejecutar(); 
        }
    }
}
