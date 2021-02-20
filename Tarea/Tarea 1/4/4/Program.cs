using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double año, dias;

            Console.WriteLine("Ingrese el año");//le pide al usuario que ingrese el año 
            año = double.Parse(Console.ReadLine());//debemos tener en cuenta que el año bisiesto es de 366 esto sucede cada 4 años 

            // los años que son divisibles por 4 no son necesariamente años bisiestos.
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                dias = (366 / 12.00);
                Console.WriteLine("El año: {0} es bisiesto", año);
                Console.WriteLine("Los dias para cada mes de este año son: {0}", dias);

            }
            else
            {
                dias = (365 / 12.00);
                Console.WriteLine("El año: {0} No es bisiesto", año);
                Console.WriteLine("Los dias para cada mes de este año son: {0}", dias);
            }

            Console.ReadKey();



        }
    }
}
