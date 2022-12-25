using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 1;
            int b = 1;
            int c;
            while (i < n)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                i++;
            }
            Console.ReadKey();

           
        }
    }
}
