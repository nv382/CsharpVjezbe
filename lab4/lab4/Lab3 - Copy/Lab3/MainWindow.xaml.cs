using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab4.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Valute.ItemsSource = Enum.GetValues(typeof(Valute));
            loadToCombo();
            
        }

        List<Uplatnica> Uplatnicas = new();
        HNBAPI HNBAPI = new HNBAPI();

        private void loadToCombo()
        {
            Valute.ItemsSource = HNBAPI.HNBAPIList;
        }

        private void Provedi_Click(object sender, RoutedEventArgs e)
        {

            Uplatnica uplatnica;
            List<Uplatnica> uplatnicas;
            
            //try
            //{
                string hitno = "Ne";
                if (Hitno.IsChecked == true)
                {
                    hitno = "Da";                    
                }

                uplatnica = new(
                        Platitelj.Text,
                        NazivPrimatelja.Text,
                        IbanPlatitelja.Text,
                        IbanPrimatelja.Text,
                        hitno,
                        Valute.Text,
                        Iznos.Text,
                        Model.Text,
                        PozivNaBrojPlatitelja.Text,
                        ModelPrimatelja.Text,
                        PozivPrimatelja.Text,
                        SifraNamjene.Text,
                        OpisPlacanja.Text,
                        Datum.Text,
                        SrednjiTecaj.Text);
                

                uplatnicas = new List<Uplatnica>();
                uplatnicas.Add(uplatnica);
                PostUplatnicas(uplatnica);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }


        public static async void PostUplatnicas(Uplatnica uplatnica)
        {

            HttpClient client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7288/api/uplatnicas");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                var uplatniceJson = JsonConvert.SerializeObject(uplatnica);
                //File.WriteAllText(@"C:\Users\Ninanardo\source\repos\Lab3 - Copy\new.json", uplatniceJson);
                //File.OpenRead(@"C:\Users\Ninanardo\source\repos\Lab3 - Copy\new.json")
                var data = new StringContent(uplatniceJson.ToString(), Encoding.UTF8, "application/json");
                var result = client.PostAsync("https://localhost:7288/api/uplatnicas", data).Result;
                result.EnsureSuccessStatusCode();
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.StatusCode.ToString(), "Transakcija provedena!");
                }
                
            }



        }

        private void Valute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SrednjiTecaj.Text = Valute.SelectedValue.ToString();
        }

        private void Ispis_Click(object sender, RoutedEventArgs e)
        {

            UplatnicaAPI uplatnicaAPI= new UplatnicaAPI();

            var uplatnicaID = int.Parse(IDtransakcije.Text);

            Uplatnica novaUplatnica = new();

            novaUplatnica=uplatnicaAPI.uplatnicas.Where(o=> o.Id== uplatnicaID).FirstOrDefault();

            Platitelj.Text = novaUplatnica.Platitelj;
            NazivPrimatelja.Text = novaUplatnica.Primatelj;
            IbanPlatitelja.Text = novaUplatnica.IbanPlatitelja;
            IbanPrimatelja.Text=novaUplatnica.IbanPrimatelja;
            //hitno,
            Valute.Text = novaUplatnica.Valuta;
            Iznos.Text = novaUplatnica.Iznos;
            Model.Text = novaUplatnica.ModelPlatitelja;
            PozivNaBrojPlatitelja.Text = novaUplatnica.PozivPlatitelja;
            ModelPrimatelja.Text = novaUplatnica.ModelPrimatelja;
            PozivPrimatelja.Text = novaUplatnica.PozivNaBrojPrimatelja;
            SifraNamjene.Text = novaUplatnica.SifraNamjene;
            OpisPlacanja.Text = novaUplatnica.OpisPlacanja;
            //Datum.Text = novaUplatnica.DatumIzvrsenja;
            SrednjiTecaj.Text = novaUplatnica.SrednjiTecaj;





        }
    }
}
