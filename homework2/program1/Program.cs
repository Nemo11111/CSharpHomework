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
            int a = 0;
            Console.WriteLine("Please input an integer, we will decompose it into prime factors:");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("it is not an integer, please input again.");
                a = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =2;i<a;i++)
            {
                while(i!=a)
                {
                    if(a%i==0)
                    {
                        Console.Write(i + " * ");//输出质数的值
                        a = a / i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Write(a);//输出最后的质数
        }
    }
}
