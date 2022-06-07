using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class HNBAPIObject
    {
        public string? broj_tecajnice { get; set; }
        public string? datum_primjene { get; set; }
        public string? drzava { get; set; }
        public string? drzava_iso { get; set; }
        public string? sifra_valute { get; set; }
        public string? valuta { get; set; }
        public int jedinica { get; set; }
        public string? kupovni_tecaj { get; set; }
        public string? srednji_tecaj { get; set; }
        public string? prodajni_tecaj { get; set; }
    }
}
