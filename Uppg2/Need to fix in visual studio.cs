using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
            double sum = 0;
            for (int i = 0; i < temperatur.Length; i++)
            {
                sum += temperatur[i];
            }
            double average = sum / temperatur.Length;
            Console.Write("Medeltemperaturen är: ");
            Console.WriteLine(average);
        }
    }
}
