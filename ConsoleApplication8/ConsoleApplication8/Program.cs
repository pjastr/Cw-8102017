using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static void WyswietlSuma(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        //static int Suma2(int a,int b)
        //{
        //    Console.WriteLine(a + b);
        //    return a + b;
        //}
        
        static void Main(string[] args)
        {
            //int liczba1 = 6;
            //int liczba2 = -23;
            //int liczba3 = Suma(liczba1, liczba2);
            //Console.WriteLine(liczba3);

            //Console.WriteLine(Suma(5, 12));
            WyswietlSuma(5, 12);

            Console.ReadKey();
        }
    }
}
