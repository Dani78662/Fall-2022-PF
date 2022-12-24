using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, m;
            char alp = 'a';
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());
            int z = n - 1;
            Console.WriteLine("------------GROUP A------------");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
             Console.ReadKey();
        }
    }
}
