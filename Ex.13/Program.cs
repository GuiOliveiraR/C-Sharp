using System;

namespace Ex._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o horario: ");
            double h = double.Parse(Console.ReadLine());

            if (h >= 7 && h < 12)
            {
                Console.WriteLine("BOM DIA!");
            }
            if (h >= 13 && h < 18)
            {
                Console.WriteLine("BOM TARDE!");
            }
        }
    }
}
