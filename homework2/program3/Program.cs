using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int[] a = new int[99];
            Boolean[] mark = new Boolean[101];
            mark[0] = false;
            mark[1] = false;
            for(int i=2;i<101;i++)
            {
                mark[i] = true;
            }
            for(int i =2;i<mark.Length;i++)
            {
                if(mark[i]==true)
                {
                    for(int j = 2*i;j<mark.Length;j+=i)
                    {
                        mark[j] = false;
                    }
                    a[num++] = i;
                }
            }
            for(int i =0;i<num;i++)
            {
                Console.WriteLine(" " + a[i] );
            }
        }
    }
}
