using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There is an array:");
            int[] a = new int[10];
            for(int i =0;i<a.Length;i++)
            {
                a[i] = i + 1;
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine("");

            //求数组的最大值与最小值
            int Max = a[0];
            int Min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>Max)
                {
                    Max = a[i];
                }
                if(a[i]<Min)
                {
                    Min = a[i];
                }
            }
            Console.WriteLine("The max is " + Max);
            Console.WriteLine("The min is " + Min);

            //求数组的平均值与和
            int All = 0;
            for(int i =0;i<a.Length;i++)
            {
                All += a[i];
            }
            double Average = Convert.ToDouble(All) / a.Length;
            Console.WriteLine("The average of all numbers is " + Average);
            Console.WriteLine("The sum of all numbers is " + All);
        }
    }
}
