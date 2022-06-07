using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public enum Valute
    {
        HRK=1, USD, EUR, GBP
    }
    public class Uplatnica
    {
        public int Id { get; set; }
        public string Platitelj { get; set; }
        public string Primatelj { get; set; }
        public string IbanPlatitelja { get; set; }
        public string IbanPrimatelja { get; set; }
        public string Hitno { get; set; }
        public string Valuta { get; set; }
        public string Iznos { get; set; }
        public string ModelPlatitelja { get; set; }
        public string PozivPlatitelja { get; set; }
        public string ModelPrimatelja { get; set; }
        public string PozivNaBrojPrimatelja { get; set; }
        public string SifraNamjene { get; set; }
        public string OpisPlacanja { get; set; }
        public string DatumIzvrsenja { get; set; }
        public string SrednjiTecaj { get; set; }

        bool provjeraPrazno(string unos)
        {
            if (unos == null)
                return false;
            return true;
        }

        public Uplatnica()
        {

        }

        public Uplatnica(string platitelj, string primatelj, string ibanPlatitelja, string ibanPrimatelja, string hitno, string valuta, string iznos, string modelPlatitelja, string pozivPlatitelja, string modelPrimatelja, string pozivNaBrojPrimatelja, string sifraNamjene, string opisPlacanja, string datumIzvrsenja, string srednjitecaj)
        {
            Platitelj = platitelj;
            Primatelj = primatelj;
            IbanPlatitelja = ibanPlatitelja;
            IbanPrimatelja = ibanPrimatelja;
            Hitno = hitno;
            Valuta = valuta;
            Iznos = iznos;
            ModelPlatitelja = modelPlatitelja;
            PozivPlatitelja = pozivPlatitelja;
            ModelPrimatelja = modelPrimatelja;
            PozivNaBrojPrimatelja = pozivNaBrojPrimatelja;
            SifraNamjene = sifraNamjene;
            OpisPlacanja = opisPlacanja;
            DatumIzvrsenja = datumIzvrsenja;
            SrednjiTecaj = srednjitecaj;
        }

        public static implicit operator Uplatnica(ActionResult<Lab4.Models.Uplatnica> v)
        {
            throw new NotImplementedException();
        }
    }
}
