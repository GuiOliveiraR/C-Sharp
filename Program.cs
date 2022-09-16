using System;

namespace Ex._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o horario: ");
            double h = double.Parse(Console.ReadLine());

            if (h >= 1 && h < 6)
            {
                Console.WriteLine("Boa Madrugada!");
            }
            else if (h >= 6 && h < 12)
            {
                Console.WriteLine("BOM DIA!");
            }
            else if (h >= 12 && h < 18)
            {
                Console.WriteLine("BOM TARDE!");
            }
            else if (h >= 18 && h <= 24)
            {
                Console.WriteLine("BOM NOITE!");
            }
            else
            { 
                Console.WriteLine("Hora Inválida");
            }
        }
    }
}
