using System;

namespace refEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usar Ref exige que a variável tenha sido iniciada antes.
            int a = 10;
            Calculadora.Triple(ref a);
            Console.WriteLine(a);
            //Para que a variável não precise ser iniciada, podemos usar o OUT do seguinte modo:
            int b = 20;
            int Triple;
            Calculadora.Triple(b, out Triple);
            Console.WriteLine(Triple);
        }
    }
}
