using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Лабораторная_работа___13
{
    class Program
    {
        private static double Sum(ref double x)
        {
            for (double i = 1; i < 10; i++)
                x += i / Math.Pow(x, i);
            return x;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            x = 0; //Missing Sum()
            Console.Write("X = ");
            Console.Write(x);
            Console.Read();
        }
    }
}