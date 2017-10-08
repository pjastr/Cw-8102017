using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //int a = 1;
            int suma = 0;
            //while (a <= n)
            //{
            //    suma += a;
            //    a++;
            //}

            //for (int i = 1; i <= n;i++ )
            //{
            //    suma += i;
            //}

            int j = 1;
            do
            {
                suma+=j;
                j++;
            }
            while (j<=n);


                Console.Write("suma = {0}", suma);
            Console.ReadKey();
        }
    }
}
