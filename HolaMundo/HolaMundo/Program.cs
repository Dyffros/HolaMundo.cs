using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hola Mundo");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pulsa cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
