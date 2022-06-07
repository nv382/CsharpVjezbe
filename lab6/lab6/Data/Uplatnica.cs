namespace lab6.Data
{
    public class Uplatnica
    {
        public int Id { get; set; }
        public string? Platitelj { get; set; }
        public string? Primatelj { get; set; }
        public string? IbanPlatitelja { get; set; }
        public string? IbanPrimatelja { get; set; }
        public string? Hitno { get; set; }
        public string? Valuta { get; set; }
        public string? Iznos { get; set; }
        public string? ModelPlatitelja { get; set; }
        public string? PozivPlatitelja { get; set; }
        public string? ModelPrimatelja { get; set; }
        public string? PozivNaBrojPrimatelja { get; set; }
        public string? SifraNamjene { get; set; }
        public string? OpisPlacanja { get; set; }
        public string? DatumIzvrsenja { get; set; }
        public string? SrednjiTecaj { get; set; }
    }
}
