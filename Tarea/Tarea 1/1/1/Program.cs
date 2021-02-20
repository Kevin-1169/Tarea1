using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-programa que lea un carácter por teclado y compruebe si es una letra mayuscula.

            Console.WriteLine("Ingrese una Letra: "); //le pide al usuario que ingrese una letra 
            char a = (char)Console.Read();

            if (Char.IsUpper(a)) //el codigo IsUpper nos sirve para ver si dicho caracter ingresado es mayuscula 
            {
                Console.WriteLine("La letra es Mayuscula");//Si la letra es Mayuscula mostrara esto en pantalla 
            }
            else
            {
                Console.WriteLine("La letra ingresada no es Mayuscula");//sino es mayuscula mostrara esto 
            }


            Console.ReadKey();
        }
    }
}





     

