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
            Console.WriteLine();

            

            for (int i = 0; i < 5; i++)
            {
                int k = i;
                for (int j = 0; j < 5; j++)
                {
                    if(k > 0)
                    {
                        matrix[i, j] = 0;
                        k--;
                    }
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
