using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Primatelj : Platitelj
    {
        public string Model { get; set; }
        public string OpisPlacanja { get; set; }

        public Primatelj(string ime, string adresa, string iban, string iznos, string model, string opisPlacanja) : base(ime, adresa, iban, iznos)        {
            Model = model;
            OpisPlacanja = opisPlacanja;
        }   
        public void Ispis()
        {
            Console.WriteLine("\nIme: {0}\nAdresa: {1}\nIBAN: {2}\nIznos: {3}\nModel: {4}\nOpis placanja: {5}\n", Naziv, Adresa, Iban, Iznos, Model, OpisPlacanja);
        }
    }
}
