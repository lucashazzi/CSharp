using System;
using System.Collections.Generic;
using System.Text;

namespace refEOut
{
    class Calculadora
    {
        public static void Triple(ref int x)
        {
            x *= 3;
        }
        public static void Triple(int x, out int y)
        {
            y = x * 3;
        }
    }
}
