using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj symbol temp");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            char znak = klawisz.KeyChar;

            Console.WriteLine(znak);

            Console.ReadKey();
        }
    }
}
