using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double mile, km, ans;
            Console.WriteLine("Enter speed in Miles");
            mile = Convert.ToInt32(Console.ReadLine());
            ans = mile * 1.609/3600;
            
            km = ans;
            Console.WriteLine("Speed in KiloMeter:" + km);
            Console.ReadKey();
        }
    }
}
