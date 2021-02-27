using System;

namespace Ej_1_Libro
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

           Console.WriteLine("Ingrese un número");

            a = Convert.ToInt32(Console.ReadLine());

            for ( int b = 0; b <= 10; b++)
            {
                Console.WriteLine(a + " x " + b + " = " + a * b);

            }

            Console.ReadKey();




          






        }
    }
}
