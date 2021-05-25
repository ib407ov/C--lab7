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
            double[,] matrix = new double[6, 5];

            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = 1 / (i + j);
                    Console.WriteLine($"{matrix[i, j]}  {i} {j}");
                }
                Console.WriteLine();
            }

            double summ = 0;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        summ += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"summ = {summ}");
            Console.Read();
        }
    }
}
