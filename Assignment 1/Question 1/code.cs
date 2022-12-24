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
            double mile, km, sum, sum1;
            Console.WriteLine("Enter speed in Miles");
            mile = Convert.ToInt32(Console.ReadLine());
            sum = mile * 1.609;
            sum1 = sum / 3600;
            km = sum1;
            Console.WriteLine("Speed in KiloMeter:" + km);
            Console.ReadLine();
            Console.ReadKey();
