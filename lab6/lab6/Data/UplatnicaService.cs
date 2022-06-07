using Newtonsoft.Json;
using System.Text;

namespace lab6.Data
{
    public class UplatnicaService : IUplatnicaService
    {
        private List<Uplatnica> _lista = new List<Uplatnica>();

        public UplatnicaService()
        {
            _lista = new List<Uplatnica>();
            string uplatniceJson = new System.Net.WebClient().DownloadString("https://localhost:7258/api/uplatnicas");
            _lista = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Uplatnica>>(uplatniceJson);
        }

        public void AddUplatnica(Uplatnica uplatnica)
        {
            HttpClient client = new HttpClient();

            client.GetAsync("https://localhost:7258/api/uplatnicas");

            var uplatniceJson = JsonConvert.SerializeObject(uplatnica);
            var data = new StringContent(uplatniceJson.ToString(), Encoding.UTF8, "application/json");
            client.PostAsync("https://localhost:7258/api/Uplatnicas", data);
           
            _lista.Add(uplatnica);
        }

        public async void DeleteUplatnica(int id)
        {
            var uplatnica = GetUplatnica(id);
            _lista.Remove(uplatnica);

            HttpClient client = new HttpClient();

            client.GetAsync("https://localhost:7258/api/");

            var uplatniceJson = JsonConvert.SerializeObject(uplatnica);
            var data = new StringContent(uplatniceJson.ToString(), Encoding.UTF8, "application/json");
            await client.DeleteAsync("https://localhost:7258/api/Uplatnicas/" + uplatnica.Id);
        }

        public Uplatnica GetUplatnica(int id)
        {
            return _lista.SingleOrDefault(x => x.Id == id);
        }

        public List<Uplatnica> GetUplatnicas()
        {
            return _lista;
        }

        public async void UpdateUplatnica(Uplatnica uplatnica)
        {
            var getUplatnica = GetUplatnica(uplatnica.Id);
            getUplatnica.Platitelj = uplatnica.Platitelj;
            getUplatnica.Primatelj = uplatnica.Primatelj;
            getUplatnica.IbanPlatitelja = uplatnica.IbanPlatitelja;
            getUplatnica.IbanPrimatelja = uplatnica.IbanPrimatelja;
            getUplatnica.Hitno = uplatnica.Hitno;
            getUplatnica.Valuta = uplatnica.Valuta;
            getUplatnica.Iznos = uplatnica.Iznos;
            getUplatnica.ModelPlatitelja = uplatnica.ModelPlatitelja;
            getUplatnica.PozivPlatitelja = uplatnica.PozivPlatitelja;
            getUplatnica.ModelPrimatelja = uplatnica.ModelPrimatelja;
            getUplatnica.PozivNaBrojPrimatelja = uplatnica.PozivNaBrojPrimatelja;
            getUplatnica.SifraNamjene = uplatnica.SifraNamjene;
            getUplatnica.OpisPlacanja = uplatnica.OpisPlacanja;
            getUplatnica.DatumIzvrsenja = uplatnica.DatumIzvrsenja;
            getUplatnica.SrednjiTecaj = uplatnica.SrednjiTecaj;

            HttpClient client = new HttpClient();

            client.GetAsync("https://localhost:7258/api/");

            var uplatniceJson = JsonConvert.SerializeObject(uplatnica);
            var data = new StringContent(uplatniceJson.ToString(), Encoding.UTF8, "application/json");
            await client.PutAsJsonAsync("https://localhost:7258/api/Uplatnicas/"+ uplatnica.Id, getUplatnica);

        }


    }
}
