using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW32
{
    class Matematyka
    {
        private static double pi = 3.14; // prywatne statyczne pole pi=3.14

        public static double  PoleKola(int r) //publiczna statyczna metoda PoleKola z parametrm r
        {
            return pi * r * r;
        }

        public static double ObwodKola(int r) //publiczna statyczna metoda ObwodKola z parametrem r
        {
            return 2 * Matematyka.pi * 4;
        }
    }
}
