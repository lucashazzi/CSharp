using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDoDolar
{
    static class ConversorDeMoeda
    {
        static double valorDolar = 5.60;

        public static double Converter(double dolaresAComprar)
        {
            return dolaresAComprar * valorDolar;
        }
    }
}
