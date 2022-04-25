/*Napisati program koji sadrži dvije varijable, jednu tipa int, a drugu tipa long u koju će biti zapisana najveća moguća vrijednost za tip long.  
 *Varijablu tipa long treba pridružiti varijabli tipa int, s tim da se obradi iznimka ako dođe do preljeva (overflow). 
 *Pomoć: vidjeti “checked” u MSDN */

using System;

namespace zad2
{
    class Program
    {
        static long maxLongValue = Int64.MaxValue;

        public static int MaxValueChecked()
        {
            int a = 0;

            try
            {
                a = checked((int)maxLongValue);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Checked: " + e.ToString());
            }
            return a;

        }

        public static int MaxValueUnchecked()
        {
            int a = 0;

            try
            {
                a = (int)maxLongValue;
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Checked: " + e.ToString());
            }
            return a;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Checked: " + MaxValueChecked());
            Console.WriteLine("\nUnchecked: " + MaxValueUnchecked());
            Console.ReadKey();
        }
    }
}
