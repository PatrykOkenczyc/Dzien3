using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Kalkulator
    {

        public double Wykonajdzialanie(int a, int b, char znak) 
        {
            double wynik = 0;
            if (znak == '+')
            {
                wynik = a + b;                
            }
            else if (znak == '-')
            {
                wynik = a - b;
                
            }
            else if (znak == '*')
            {
                wynik = a * b;
                
            }
            else if (znak == '/')
            {
                wynik = a / b;
                
            }
            else
            {
                throw new Exception("Niepoprwany operator");
            }
            return wynik;
        }
    }
}
