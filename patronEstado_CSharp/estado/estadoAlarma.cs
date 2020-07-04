using System;
using System.Collections.Generic;
using System.Text;

namespace estado
{
    class estadoAlarma:estado
    {
        caldera micaldera;


        public estadoAlarma(caldera Pcaldera)
        {
            micaldera = Pcaldera;
        }
        public void trabajar()
        {
            Console.WriteLine("ALARMA! alta Temperatura!");
            micaldera.Temperatura -= 5;

            if (micaldera.Temperatura < 90 || micaldera.Combustible <= 0)
                micaldera.colocarEstado(micaldera.Espera);
        }
        public void cortaFuego()
        {
            Console.WriteLine("No se encuentra prendida");
        }
        public void ponerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible con temperatura alta");

        }
        public void forzarFuego()
        {
            Console.WriteLine("Aumentara la temperatura");
            micaldera.Combustible -= 3;
            micaldera.Temperatura += 10;
        }
        public override string ToString()
        {
            return string.Format("Alarma-> temp{0}, temp{1}", micaldera.Temperatura, micaldera.Combustible);
        }








    }

}
