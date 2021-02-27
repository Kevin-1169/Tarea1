using System;

namespace Ej_2_Libro
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, potencia, total=0;

            Console.WriteLine("ingrese un numero que desea elevar:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el número con el cual desea elevar");
            potencia = Convert.ToInt32(Console.ReadLine());

            for (int uwu = 0; uwu < potencia-1; uwu++) 
            {
                if (total == 0)
                {
                    total = a * a;
                }
                else
                {
                    total =total * a;
                }
                
            }

            Console.WriteLine(total);

            Console.ReadLine();
            












        }
    }
}
