using System;
using System.Collections.Generic;
using System.Text;

namespace estado
{
    class estadoCalentando : estado
    {
        caldera micaldera;

        public estadoCalentando(caldera pCaldera)
        {
            micaldera = pCaldera;
        }
        public void trabajar()
        {
            if (micaldera.Combustible > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                
                Console.WriteLine("estamos calentando");
                micaldera.Combustible -= 3;
                micaldera.Temperatura += 10;
               
            }
            if (micaldera.Temperatura > 100)
                micaldera.colocarEstado(micaldera.Alarma);
            else if (micaldera.Temperatura > 80)
                micaldera.colocarEstado(micaldera.Espera);

            if (micaldera.Combustible <= 0)
                micaldera.colocarEstado(micaldera.Espera);
        }
        public void cortaFuego()
        {
            Console.WriteLine("Cortamos Fuego");
            micaldera.colocarEstado(micaldera.Espera);
        }

        public void forzarFuego()
        {
            Console.WriteLine("El fuego ya esta Prendido");
        }

        public void ponerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible cuando esta prendida");
        }
        public override string ToString()
        {
        
            return string.Format("Calentando-> tem{0}, comb{1}", micaldera.Temperatura, micaldera.Combustible);
        }
    }
}
