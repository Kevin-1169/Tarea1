using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.Write("Ingrese un Número del 1 al 7: ");//le decimos al usuario que solo puede ingresar un numero del 1 al 7
            num = Convert.ToInt16(Console.ReadLine());

            switch (num)
            {

                //aca especificamos que si el usuario ingresa un numero del 1 al 7 que le muestre en pantalla el dia que corresponde 

                case 1:
                    Console.WriteLine("El dia es Lunes, si es laboral");
                    break;
                case 2:
                    Console.WriteLine("El dia es Martes, si es laboral");
                    break;
                case 3:
                    Console.WriteLine("El dia es Miercoles, si es laboral");
                    break;
                case 4:
                    Console.WriteLine("El dia es Jueves, si es laboral");
                    break;
                case 5:
                    Console.WriteLine("El dia es Viernes,si es laboral");
                    break;
                case 6:
                    Console.WriteLine("El dia es Sabado, no es laboral");
                    break;
                case 7:
                    Console.WriteLine("El dia es Domingo, no es laboral");
                    break;
            }
            Console.ReadKey();





        }
    }
}
