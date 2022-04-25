using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Platitelj
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Iban { get; set; }
        public string Iznos { get; set; }

        public Platitelj(string ime, string adresa, string iban, string iznos)
        {
            Naziv = ime;
            Adresa = adresa;
            Iban = iban;
            Iznos = iznos;
        }
         public void Ispis()
        {
            Console.WriteLine("\nIme: {0}\nAdresa: {1}\nIBAN: {2}\nIznos: {3}\n", Naziv, Adresa, Iban, Iznos);
        }
    }
}
