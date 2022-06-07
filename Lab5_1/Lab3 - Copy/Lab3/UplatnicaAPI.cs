using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class UplatnicaAPI
    {
        public List<Uplatnica> uplatnicas { get; set; }

        public UplatnicaAPI()
        {
            uplatnicas = new List<Uplatnica>();
            string uplatniceJson = new System.Net.WebClient().DownloadString("https://localhost:7258/api/uplatnicas");
            uplatnicas=Newtonsoft.Json.JsonConvert.DeserializeObject<List<Uplatnica>>(uplatniceJson);


        }

    }
}
