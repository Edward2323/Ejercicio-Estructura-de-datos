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

        public static void EjerccicioOptimizado()
        {
            try
            {
                Console.Write("Ingrese tamaño del arreglo: ");

                int size = Convert.ToInt32(Console.ReadLine());
                int[] vector = new int[size];
                int suma = 0;

                Console.Write("Ingrese valores del arreglo: ");

                for (int i = 0; i < size; i++)
                {
                    vector[i] = Convert.ToInt32(Console.ReadLine());

                    suma = suma + vector[i];
                }

                Console.WriteLine(suma);


            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                EjerccicioOptimizado();
            }
        }


        public static void CalculoPromedio()
        {
            List<double> valores = new();
            double suma = 0;
            double promedio = 0;


            try
            {

                Console.WriteLine("Inserte valores a promediar, cuando introduzca todos los numeros," +
                    " introduzca 0 para detener la entrada de datos");

                while (true) 
                {
                    Console.Write("valor ");
                    double valor = Convert.ToDouble(Console.ReadLine());

                    if(valor > 0)
                    {
                        valores.Add(valor);
                        suma = suma + valor;
                        continue;
                    }

                    break;
                }

                promedio = suma / valores.Count;
                Console.WriteLine("El promedio es: " + promedio);
            }
            catch (Exception e)
            {

                Console.WriteLine("Ocurrio un error");
                CalculoPromedio();
            }
        }
    }
}
