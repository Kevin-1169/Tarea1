using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            double compra, resultado;
            int descuento = 20;//declaramos descuento y el asignamos 20 que sera el descuento de dicha compra si es mayor a 300

            Console.WriteLine("Ingrese la cantidad de la compra: ");//le pedimos al usuario que ingrese la cantidad de compra 
            compra = double.Parse(Console.ReadLine());//le la cantidad ingresada y la guarda 

            resultado = (compra * descuento / 100);//hace la operación 

            if (compra > 300)//aca le decimos que si la compra es mayor de 300
            {
                Console.WriteLine("El descuento es de: Q.{0}", resultado);//muestra en pantalla este mensaje 
            }
            else//sino 
            {
                Console.WriteLine("El cliente no tiene descuento");//muestre esto en pantalla 

            }
            Console.ReadKey();





        }
    }
}
