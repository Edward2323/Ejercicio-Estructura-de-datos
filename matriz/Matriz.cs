using System;

namespace matriz
{
    public class Matriz
    {
        private int[,] matriz;
        private int filas;
        private int columnas;

        public void Ejecutar()
        {
            SolicitarDimensiones();
            LlenarMatriz();
            MostrarMatriz();
            (int max, int filaMax, int colMax) = EncontrarMaximo();
            (int min, int filaMin, int colMin) = EncontrarMinimo();

            Console.WriteLine($"\nValor máximo: {max} en la posición [{filaMax},{colMax}]");
            Console.WriteLine($"Valor mínimo: {min} en la posición [{filaMin},{colMin}]");
        }

        private void SolicitarDimensiones()
        {
            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            matriz = new int[filas, columnas];
        }

        private void LlenarMatriz()
        {
            Console.WriteLine("\nIngrese los valores de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private void MostrarMatriz()
        {
            Console.WriteLine("\nMatriz ingresada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        private (int max, int fila, int columna) EncontrarMaximo()
        {
            int max = matriz[0, 0];
            int filaMax = 0, colMax = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > max)
                    {
                        max = matriz[i, j];
                        filaMax = i;
                        colMax = j;
                    }
                }
            }

            return (max, filaMax, colMax);
        }

        private (int min, int fila, int columna) EncontrarMinimo()
        {
            int min = matriz[0, 0];
            int filaMin = 0, colMin = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] < min)
                    {
                        min = matriz[i, j];
                        filaMin = i;
                        colMin = j;
                    }
                }
            }

            return (min, filaMin, colMin);
        }
    }
}
