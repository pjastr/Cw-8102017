using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj pierwszą liczbę");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            int liczba3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(liczba1);
            //Console.WriteLine(liczba2);
            //Console.WriteLine(liczba3);


            Console.WriteLine("Max= {0}",Math.Max(Math.Max(liczba1, liczba2), liczba3));
            Console.WriteLine("Min= {0}",Math.Min(Math.Min(liczba1, liczba2), liczba3));
            
            
            Console.ReadKey();

        }
    }
}
