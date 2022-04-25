using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            NalogZaPlacanje nalogZaPlacanje = new NalogZaPlacanje();
            List<NalogZaPlacanje> nalogZaPlacanjes = new List<NalogZaPlacanje>();
            List<Platitelj> platiteljs = new List<Platitelj>();
            List<Primatelj> primateljs = new List<Primatelj>();
            int count = -1;
            Console.WriteLine("Dobro došli u program za provođenje naloga.\n" +
                "Počnite s unosom platitelja.\n");
            string prekid = "a";
            while (!prekid.Equals("q"))
            {
                platiteljs.Add(nalogZaPlacanje.StvoriPlatitelja());
                primateljs.Add(nalogZaPlacanje.StvoriPrimatelja());
                count++;

                Console.WriteLine("Stisnite p za provođenje i ispisivanje naloga.\n");
                prekid = Console.ReadLine();
                if (prekid.Equals("p"))
                {
                    platiteljs[count].Ispis();
                    primateljs[count].Ispis();
                }
                Console.WriteLine("Stisnite i za ispis svih naloga.\n");
                prekid = Console.ReadLine();
                if (prekid.Equals("i"))
                {
                    for (int i = 0; i < primateljs.Count; i++)
                    {
                        platiteljs[i].Ispis();
                        primateljs[i].Ispis();
                    }
                }
                Console.WriteLine("Stisnite q za prekid programa.");
                prekid = Console.ReadLine();
            }
            
            

        }
    }
}
//json se šalje sa post i parsira u bazu u post u bazu get 