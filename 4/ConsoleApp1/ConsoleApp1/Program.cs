using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[5, 5];
            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(0, 10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            double[] arr = new double[5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i == j)
                    {
                        arr[i] = matrix[i, j];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5 ; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        double t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }

                }
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i == j)
                    {
                        matrix[i, j] = arr[i];
                    }
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
