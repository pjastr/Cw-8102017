using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj znak");
            int numerZnaku = Console.Read();
            char znak = (char)numerZnaku;
            Console.ReadLine();
            Console.WriteLine("podaj liczbę");
            int liczba = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();

        }
    }
}
