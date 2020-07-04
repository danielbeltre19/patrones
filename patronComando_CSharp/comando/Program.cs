using System;

namespace comando
{
    class Program
    {
        static void Main(string[] args)
        {
            carro miAuto = new carro();
            controlremoto control = new controlremoto(miAuto);
            string opciones;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("1-Encender, 2-Apagar, 3-Preder Alarma, 4-Apagar Alarma, 5-Salir");
                Console.WriteLine("  ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Elija la Opcion: ");
                    


                opciones = Console.ReadLine();

                Console.WriteLine("  ");
                if (opciones == "1")
                    control.boton(0);
                if (opciones == "2")
                    control.boton(1);
                if (opciones == "3")
                    control.boton(2);
                if (opciones == "4")
                    control.boton(3);

            } while (opciones != "5"); 
        }
    }
}
