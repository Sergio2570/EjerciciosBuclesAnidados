using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n03.ComprobarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Dame un número positivo mayor que 1");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num > 1)
                {
                    int count = 0;
                    for (int i = 1; i < num; i++)
                    {
                        if (num%i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine("Es primo");
                    }
                    else
                    {
                        Console.WriteLine("No es primo");
                    }
                }
                else
                {
                    Console.WriteLine("El número tiene que ser positivo mayor que 1");
                }
            }
            else
            {
                Console.WriteLine("Dato inválido");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
