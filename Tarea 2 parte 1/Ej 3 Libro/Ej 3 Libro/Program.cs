using System;

namespace Ej_3_Libro
{
    class Program
    {
        static void Main(string[] args)
        {

            int divisor = 1, divisores = 0;

            String numeros = "";
            for (int uwu = 1; uwu <= 5; uwu++)
            {
                divisor = 1;
                do
                {

                    if (uwu % divisor == 0)
                    {
                        divisores++;
                    }

                    divisor++;

                } while (divisor <= uwu);

                if (divisores == 2)
                {
                    numeros = " - " + uwu;

                }

            }
            Console.WriteLine(numeros);

            Console.ReadKey();




        }
    }
    
    }
       

