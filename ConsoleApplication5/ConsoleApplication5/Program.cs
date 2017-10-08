using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 6;

            double c = 2.344, d = -4.223;

            float e = 3.455f, g;
            g = 234.3433f;

            Console.WriteLine("a+c= {0}", a + c);
            Console.WriteLine("b-d= {0}", b - d);
            Console.WriteLine("c*b= {0}", c * b);
            Console.WriteLine("b/a= {0}", b / a);

            Console.WriteLine("a%b ={0}", a % b);

            Console.ReadKey();
        }
    }
}
