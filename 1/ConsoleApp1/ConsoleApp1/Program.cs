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
            double[,] matrix = new double[5,5];
            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(-9, 10);
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i % 2 == 0 && j % 2 == 0 && matrix[i,j] < 0)
                    {
                        k++;
                    }
                }
            }
            Console.WriteLine($"elements = {k}");
            Console.Read();
        }
    }
}
