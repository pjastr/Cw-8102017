using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        //static int ObliczSume(int a,int b)
        //{
        //    return a + b;
        //}

        static void WyswietlSume(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //bradzo zła praktyka!!
        static int ObliczIWyswietlSume(int a,int b)
        {
            int suma = a + b;
            Console.WriteLine(suma);
            return suma;
        }
        
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            /*
            int max = a;
            if(b>max) max = b;
            if(c>max) max = c;

            int min = a;
            if(b<min) min = b;
            if(c<min) min = c;

            Console.WriteLine("Najwyższa: " + max +" Najniższa: " + min);
            */

            //int[] arr = new int[] { a, b, c };
            //Console.WriteLine("Max" + arr.Max());
            //Console.WriteLine("Min" + arr.Min());

            Console.WriteLine("Max= {0}", Math.Max(Math.Max(a,b),c));
            Console.WriteLine("Min= {0}", Math.Min(Math.Min(a, b), c));
            Console.ReadKey();



            

           
            }
        
    }
}
