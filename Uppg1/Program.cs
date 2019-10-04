using System;

namespace Array_uppgifter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv in ett heltal: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 5 - 1; i >= 0; i--)
            {
                Console.WriteLine("Nr: " + v[i]);

            }
        }
    }
}
