using System;

namespace Decorador
{
    class Program
    {
       
        static void Main(string[] args)
        {
            

            componentes miAuto = new auto("2020", "2 puertas", 200000);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(miAuto);

            ((auto)miAuto).puertas(true);

            Console.WriteLine("--------");

            miAuto = new SistemaSonido(miAuto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("--------");

            miAuto = new nitrogeno(miAuto);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            //este type cast es para usar algo propio del nitrogeno 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            ((nitrogeno)miAuto).usaN();

            Console.WriteLine("--------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            miAuto = new suspension(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("--------");


            miAuto = new color(miAuto);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("--------");

            return;
        }
        
    }
}
