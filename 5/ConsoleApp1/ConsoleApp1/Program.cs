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
            double[,] arr = new double[5, 5];
            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double[,] matrix = new double[5, 5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; i < 5; j ++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            matrix[i, j] = arr[i + 1, j] + arr[i, j + 1] / 2;
                        }
                        else if (j == 4)
                        {
                            matrix[i, j] = arr[i + 1, j] + arr[i, j - 1] / 2;
                        }
                        else
                        {
                            matrix[i, j] = arr[i + 1, j] + arr[i, j + 1] + arr[i,j - 1] / 3;
                        }
                    }
                    else if(j == 0)
                    {
                        if(i == 4)
                        {
                            matrix[i, j] = arr[i - 1, j] + arr[i, j + 1] / 2;
                        }
                        else
                        {
                            matrix[i, j] = arr[i + 1, j] + arr[i + 1, j] + arr[i, j + 1] / 3;
                        }
                    }
                    else if(i == 4)
                    {
                        if(j == 4)
                        {
                            matrix[i, j] = arr[i - 1, j] + arr[i, j - 1] / 2;
                        }
                        else
                        {
                            matrix[i, j] = arr[i - 1, j] + arr[i, j + 1] + arr[i, j - 1] / 3;
                        }
                    }
                    else if(j == 4)
                    {
                        matrix[i - 1, j] = arr[i, j + 1] + arr[i, j] + arr[i, j - 1] / 3;
                    }
                    else
                    {
                        matrix[i, j] = arr[i + 1, j] + arr[i - 1, j] + arr[i, j + 1] + arr[i, j - 1] / 4;
                    }
                    Console.Write($"{matrix[i, j]} [{i}][{j}]");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
