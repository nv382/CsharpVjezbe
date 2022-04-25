using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using lab2;


namespace lab2
{
    class NalogZaPlacanje
    {
        public static Boolean isAlpha(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z\\s]+");
            return rg.IsMatch(strToCheck);
        }

        public static Boolean isAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$");
            return rg.IsMatch(strToCheck);
        }

        public static Boolean isNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^\p{N}[\p{N}]*$");
            return rg.IsMatch(strToCheck);
        }

        public Platitelj StvoriPlatitelja()
        {
            string ime = null;
            string adresa = null;
            string iban = null;
            string iznos = null;

            while (iznos == null)
            {
                Console.WriteLine("Unesite naziv platitelja: ");
                ime = Console.ReadLine();
                while (!isAlpha(ime) || ime == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    ime = Console.ReadLine();
                }

                Console.WriteLine("Unesite adresu platitelja: ");
                adresa = Console.ReadLine();
                while (!isAlphaNumeric(adresa) || adresa == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    adresa = Console.ReadLine();
                }

                Console.WriteLine("Unesite IBAN platitelja: ");
                iban = Console.ReadLine();
                while (!isAlphaNumeric(iban) || iban == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    iban = Console.ReadLine();
                }

                Console.WriteLine("Unesite iznos platitelja: ");
                iznos = Console.ReadLine();
                while (!isNumeric(iznos))
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    iznos = Console.ReadLine();
                }
            }
            Platitelj platitelj = new Platitelj(ime, adresa, iban, iznos);
            return platitelj;
        }

        public Primatelj StvoriPrimatelja()
        {
            string ime = null;
            string adresa = null;
            string iban = null;
            string iznos = null;
            string model = null;
            string opisPlacanja = null;

            Console.WriteLine("Unesite primatelja.\n");

            while (opisPlacanja == null)
            {
                Console.WriteLine("Unesite naziv primatelja: ");
                ime = Console.ReadLine();
                while (!isAlpha(ime) || ime == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    ime = Console.ReadLine();
                }

                Console.WriteLine("Unesite adresu primatelja: ");
                adresa = Console.ReadLine();
                while (!isAlphaNumeric(adresa) || adresa == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    adresa = Console.ReadLine();
                }

                Console.WriteLine("Unesite IBAN primatelja: ");
                iban = Console.ReadLine();
                while (!isAlphaNumeric(iban) || iban == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    iban = Console.ReadLine();
                }

                Console.WriteLine("Unesite iznos primatelja: ");
                iznos = Console.ReadLine();
                while (!isNumeric(iznos) || iznos == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite.");
                    iznos = Console.ReadLine();
                }

                Console.WriteLine("Unesite model primatelja:");
                model = Console.ReadLine();
                while (!isAlphaNumeric(model) || model == null)
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    model = Console.ReadLine();
                }

                Console.WriteLine("Unesite opis plaćanja primatelja:");
                opisPlacanja = Console.ReadLine();
                while (!isAlphaNumeric(opisPlacanja))
                {
                    Console.WriteLine("Unos nije dobar, ponovite!");
                    opisPlacanja = Console.ReadLine();
                }
            }
            Primatelj primatelj = new Primatelj(ime, adresa, iban, iznos, model, opisPlacanja);
            return primatelj;
        }

    }

    
}
