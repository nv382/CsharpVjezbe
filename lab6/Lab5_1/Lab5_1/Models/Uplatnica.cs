using System;
using System.Collections.Generic;

namespace Lab5_1.Models
{
    public partial class Uplatnica
    {
        public long Id { get; set; }
        public string Platitelj { get; set; } = null!;
        public string Primatelj { get; set; } = null!;
        public string IbanPlatitelja { get; set; } = null!;
        public string? IbanPrimatelja { get; set; }
        public string Hitno { get; set; } = null!;
        public string Valuta { get; set; } = null!;
        public string Iznos { get; set; } = null!;
        public string ModelPlatitelja { get; set; } = null!;
        public string PozivPlatitelja { get; set; } = null!;
        public string ModelPrimatelja { get; set; } = null!;
        public string PozivNaBrojPrimatelja { get; set; } = null!;
        public string SifraNamjene { get; set; } = null!;
        public string OpisPlacanja { get; set; } = null!;
        public string DatumIzvrsenja { get; set; } = null!;
        public string SrednjiTecaj { get; set; } = null!;
    }
}
