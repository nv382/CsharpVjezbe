/*Napisati program koji upisuje dva cjelobrojna broja i ispisuje rezultat dijeljenja ta dva broja.  
Rezultat treba ispisati u sljedećim formatima (Currency, Integer, Scientific, Fixed-point, General, Number, Hexadecimal). 
Prilikom upisa nekog podatka sa tipkovnice, podatak se učitava kao tip string, a ako nam treba tip int moramo ga pretvoriti uz pomoć ugrađenih metoda. 
Pripaziti da se obrade sve iznimke*/

using System;
using System.Globalization;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prvi broj: ");
            double prvi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Unesite drugi broj: ");
            double drugi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            try
            {
                Console.WriteLine("Rezultat dijeljenja je " + (prvi / drugi) + "\n");
                Console.WriteLine(
                "(C) Currency: . . . . . . . {0:C}\n" +
                "(I) Integer:. . . . . . . . {0}\n" +
                "(E) Scientific: . . . . . . {0:E}\n" +
                "(F) Fixed point:. . . . . . {0:F}\n" +
                "(G) General:. . . . . . . . {0:G}\n" +
                "(N) Number: . . . . . . . . {0:N}\n" +
                "(X) Hexadecimal:. . . . . . {0:X}\n",
                (prvi / drugi).ToString());
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", drugi);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine($"Overflow: {e}");
            }

            Console.ReadKey();
        }
    }
}

