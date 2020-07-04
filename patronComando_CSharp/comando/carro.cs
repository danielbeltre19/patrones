using System;
using System.Collections.Generic;
using System.Text;

namespace comando
{
    class carro
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Se prendio el Carro");
        }
        public void apagar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se apago el Carro");
        }
        public void ponerAlarma ()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Se prendio la Alarma");
        }
        public void quitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Se apago la Alarma");
        }
    }
}
