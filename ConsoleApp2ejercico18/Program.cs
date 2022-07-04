using System;

namespace ConsoleApp2ejercico18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingrese el numero");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
                Console.WriteLine("el numero es positivo");
            else
                Console.WriteLine("el numero es negativo");
            Console.ReadLine();

        }
    }
}
