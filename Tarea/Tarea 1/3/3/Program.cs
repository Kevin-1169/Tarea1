using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoraTrabajo, salario, PagoHora, Pagoextra;//declaracion de las variables tipo entero 
            PagoHora = 16;//le asignamos valor a Pago de hora 
            Pagoextra = 20;//le asignamos valor a pago extra 

            Console.WriteLine("Ingrese horas trabajadas:");//le pedimos al usuario que ingrese las horas trabajadas 
            HoraTrabajo = int.Parse(Console.ReadLine());

            if (HoraTrabajo <= 40)//si las hora de trabajo menor o igual que 40 
            {
                salario = (HoraTrabajo * PagoHora);//hara este procedimiento
                Console.WriteLine("El pago es: Q. {0}.00", salario);//muestra en pantalla su sueldo 
            }
            else//sino
            {
                salario = (40 * PagoHora) + ((HoraTrabajo - 40) * Pagoextra);//si su sueldo es mayor de 40 horas hara este procedimiento
                Console.WriteLine("El salario es: Q.{0}.00", salario);//y le muestra su sueldo 
            }
            Console.ReadKey();

        }
    }
}
