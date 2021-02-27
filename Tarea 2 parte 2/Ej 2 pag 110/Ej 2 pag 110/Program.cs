using System;

namespace Ej_2_pag_110
{
    class Program
    {
        static void Main(string[] args)
        {
            double radianes, grados, opcion;

            Console.WriteLine("opcion 1 radianes a grados \nopcion 2 grados a radianes");
            opcion = Convert.ToInt32(Console.ReadLine());

            if(opcion==1)
            {
                Console.WriteLine("Ingrese los radianes:");
                radianes = Convert.ToInt32(Console.ReadLine());
                grados = radianes * 180 / 3.1418;

                Console.WriteLine("Los grados son: " + grados);

            }else if(opcion==2)
            {
                Console.WriteLine("Ingrese los grados: ");
                grados = Convert.ToInt32(Console.ReadLine());
                radianes = grados * 3.1418 / 180;

                Console.WriteLine("Los radianes son: " + radianes);

            }else
            {
                Console.WriteLine("No ha ingresado una opcion valida");

            }


            Console.ReadKey();




        }
    }
}
