using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Lab3
{
    public class HNBAPI
    {
        public List<HNBAPIObject> HNBAPIList { get; set; }
        
        public HNBAPI()
        {
            HNBAPIList = new List<HNBAPIObject>();
            string srednjiTecaj = new System.Net.WebClient().DownloadString("https://api.hnb.hr/tecajn/v2");
            HNBAPIList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<HNBAPIObject>>(srednjiTecaj);
        }
    }
}
