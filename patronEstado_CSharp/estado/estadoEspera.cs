using System;
using System.Collections.Generic;
using System.Text;

namespace estado
{
    class estadoEspera:estado
    {
        caldera micaldera;

        public estadoEspera(caldera pCaldera)
        {
            micaldera = pCaldera;
        }
        public void trabajar()
        {
            micaldera.Temperatura -= 5;
            if (micaldera.Temperatura < 60 && micaldera.Combustible > 0)
                micaldera.colocarEstado(micaldera.Calentado);
        }
        public void cortarFuego()
        {
            Console.WriteLine("ni hay fuego prendido");
        }
        public void ponerCombustible()
        {
            Console.WriteLine("colocando combustible");
            micaldera.Combustible += 28;
        }

        public void cortaFuego()
        {
            
        }

        public void forzarFuego()
        {
            if (micaldera.Combustible > 0)
            {
                Console.WriteLine("Se ha prendido el fuego de manera forzada");
                micaldera.Combustible -= 3;
                micaldera.Temperatura += 10;

                if (micaldera.Temperatura > 100)
                    micaldera.colocarEstado(micaldera.Alarma);
            }

            
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return string.Format("Espera-> temp{0},comb{1}", micaldera.Temperatura, micaldera.Combustible);
        }
    }
}
