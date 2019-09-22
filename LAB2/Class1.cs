using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X");
            double X = double.Parse((Console.ReadLine()));
            Console.WriteLine("Enter Y");
            double Y = double.Parse((Console.ReadLine()));
            Console.WriteLine("Enter Z");
            double Z = double.Parse((Console.ReadLine()));
            double Chis, Znam, F;
            Chis = Math.Max(X * Z, Math.Min(Y, Z));
            Znam = X * X + Math.Sin(Z * Y);
            if (Znam == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                F = (Chis / Znam);
                Console.WriteLine(F);
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
