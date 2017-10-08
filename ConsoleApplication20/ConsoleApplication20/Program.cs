using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int suma=0;
            //for(int i=1;i<=n;i++)
            //{
            //    suma += i;
            //}

            //int j = 1;
            //while(j<=n)
            //{
            //    suma += j;
            //    j++;
            //}

            int k =1;
            do
            {
                suma += k;
                k++;
            }
            while (k <= n);

        }
    }
}
