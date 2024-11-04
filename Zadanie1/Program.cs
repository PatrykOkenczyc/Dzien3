using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();

            Console.WriteLine("Podaj liczbę nr 1: ");
            string liczba1 = Console.ReadLine();
            Console.WriteLine("Podaj liczbę nr 2: ");
            string liczba2 = Console.ReadLine();

            int l1 = Convert.ToInt32(liczba1);
            int l2 = Convert.ToInt32(liczba2);

            Console.WriteLine("Jaką operację chcesz wykonać (+ - * /): ");
            string dzialanie = Console.ReadLine();
            char znak = char.Parse(dzialanie);

            double wynik = kalkulator.Wykonajdzialanie(l1, l2, znak);


            Console.WriteLine($"Wynik to: {wynik}");
            Console.ReadKey();

        }
    }
}
