using System;

namespace _6
{
    class Program
    {
        public static bool EsPrimo(int numero)
        {
            { 

            int divisor = 2;
            while (divisor < numero)
            {
                if (numero % divisor == 0)
                    return false;//si el numero ingresado no es primo muestra en pantalla false  que significa falso 
                divisor++;
            }
            return true;//si el numero ingresado es divisible solo entre un numero nos mostrare que es verdadero 
        }

    }
    static void Main(string[] args)
    {
        int numero; //declarcion de variables de tipo entero 
        Console.WriteLine("Ingrese un numero");//le pide al usuario que ingrese un numero 
        numero = Convert.ToInt32(Console.ReadLine());//guarda el numero ingresado 

        if (numero > 0)//aca nos verifica si el numero ingresado es mayor a 0 
        {
            Console.WriteLine("El numero que ingreso es:" + EsPrimo(numero));
        }
        Console.ReadKey();




    }
}
}
