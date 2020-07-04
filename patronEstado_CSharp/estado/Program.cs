using System;

namespace estado
{
    class Program
    {
        static void Main(string[] args)
        {
            caldera micaldera = new caldera();
            string opciones;

            do
            {
                Console.WriteLine("  ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Dale a 'ENTER' para ver el estado de la TEMPERATURA de la Caldera");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  ");
                Console.WriteLine("1.Cortar Fuego 2.Poner Combustible 3.Forzar Fuego 4.Salir");
                Console.WriteLine("  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Elija la opcion: ");
                opciones = Console.ReadLine();
                Console.WriteLine("  ");

                micaldera.trabajar();

                if (opciones == "1")
                    micaldera.cortaFuego();

                if (opciones == "2")
                    micaldera.ponerCombustible();

                if (opciones == "3")
                    micaldera.forzarFuego();

                Console.WriteLine(micaldera);

            } while (opciones != "4");
        }
    }
}
