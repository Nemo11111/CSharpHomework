using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = " ";
            double a = 0.0;
            double b = 0.0;
            Console.WriteLine("Please input two numbers:");
            Console.Write("a = ");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.Write("b = ");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.WriteLine("a * b = " + (a * b));
        }
    }
}
