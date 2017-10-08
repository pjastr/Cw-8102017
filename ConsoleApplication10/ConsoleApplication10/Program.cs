using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b)
            {
                if (a<=c)
                {
                    Console.WriteLine("Max = {0}, Min ={1}", c, b);
                }
                else if (b<=c)
                {
                    Console.WriteLine("Max = {0}, Min ={1}", a, b);
                }
                else
                {
                    Console.WriteLine("Max = {0}, Min ={1}", a, c);
                }
            }
            else
            {
                if (b <= c)
                {
                    Console.WriteLine("Max = {0}, Min ={1}", c, a);
                }
                else if (a <= c)
                {
                    Console.WriteLine("Max = {0}, Min ={1}", b, a);
                }
                else
                {
                    Console.WriteLine("Max = {0}, Min ={1}", b, c);
                }
            }

            Console.ReadKey();
        }
    }
}
