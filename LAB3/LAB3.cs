using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число вашего рождения \n m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш номер в списке группы \n n = ");
            int n = Convert.ToInt32(Console.ReadLine());
        
            int[,] matrix = new int[m, n];

            Random ran = new Random();

            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = ran.Next(-100, 100);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nМаксимальное значение в строках: ");
            for (int i = 0; i < m; i++)
            {
                int maxLine = matrix[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > maxLine)
                    {
                        maxLine = matrix[i, j];
                    }
                }
                Console.WriteLine("Строка {0}, значение: {1}", i, maxLine);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}