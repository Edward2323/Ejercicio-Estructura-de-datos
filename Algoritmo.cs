using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public static class Algoritmo
    {
        public static void Ejercicio()
        {
			try
			{
				Console.Write("Ingrese tamaño del arreglo");
				int size = Convert.ToInt32(Console.ReadLine());
				int[] vector = new int[size];
                int suma = 0;

                Console.Write("Ingrese valores del arreglo: ");
                for (int i = 0; i < size; i++)
                {
					vector[i] = Convert.ToInt32(Console.ReadLine());
                }

				for (int i = 0; i < size; i++)
				{
					suma = suma + vector[i];	
				}

				Console.WriteLine(suma);


			}
			catch(Exception e)
			{

				Console.WriteLine(e);
			}
        }
    }
}
