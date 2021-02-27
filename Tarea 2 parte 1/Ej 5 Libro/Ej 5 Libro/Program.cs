using System;

namespace Ej_5_Libro
{
    class Program
    {
        static void Main(string[] args)
        {

            double promedio;
            int mayor = 0, menor = 100, total = 0, edad, numero;

            Console.WriteLine("ingrese el número de personas:");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int ewe =0;ewe < numero; ewe++)
            {
                Console.WriteLine("ingrese edad:");

                edad = Convert.ToInt32(Console.ReadLine());

                total = total + edad;

                if (edad > mayor)
                {
                    mayor = edad;
                }
                if (edad< menor)
                {
                    menor = edad;
                }



            }
            promedio = total / numero;

            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("El mayor es: "+ mayor);
            Console.WriteLine("El menor es: " + menor);

            Console.ReadKey();








           




        }
    }
}
