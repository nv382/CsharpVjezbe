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

        string Platitelj;
        string Primatelj;
        string IbanPlatitelja;
        string IbanPrimatelja;
        string Hitno;
        string Valuta;
        string Iznos;
        string ModelPlatitelja;
        string PozivPlatitelja;
        string ModelPrimatelja;
        string PozivNaBrojPrimatelja;
        string SifraNamjene;
        string OpisPlacanja;
        string DatumIzvrsenja;

        bool provjeraPrazno(string unos)
        {
            if (unos == null)
                return false;
            return true;
        }

        public Uplatnica(string platitelj, string primatelj, string ibanPlatitelja, string ibanPrimatelja, string hitno, string valuta, string iznos, string modelPlatitelja, string pozivPlatitelja, string modelPrimatelja, string pozivNaBrojPrimatelja, string sifraNamjene, string opisPlacanja, string datumIzvrsenja)
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
        }

    }
}
