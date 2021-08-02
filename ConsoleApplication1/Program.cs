using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Napisati program kojim se izračunava zbir s=2+22+23+24+...+2n*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0;
            Console.WriteLine("Unesite n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = 2;
                for (int j = 1; j < i + 1; j++)
                    x *= 2;
                    s += x;
            }

            Console.WriteLine("Zbir iznosi: " + s);
            Console.ReadKey();
        }
    }
}
