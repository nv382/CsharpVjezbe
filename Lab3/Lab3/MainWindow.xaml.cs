using System;
using System.Collections.Generic;
using System.Linq;
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
        }


        private void Provedi_Click(object sender, RoutedEventArgs e)
        {
            
            List<Uplatnica> list = new();
            Uplatnica uplatnica;
            
            try
            {
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
                        (string)Valute.SelectedItem,
                        Iznos.Text,
                        Model.Text,
                        PozivNaBrojPlatitelja.Text,
                        ModelPrimatelja.Text,
                        PozivPrimatelja.Text,
                        SifraNamjene.Text,
                        OpisPlacanja.Text,
                        DatumIzvrsenja.Text);

                list.Add(uplatnica);
                MessageBox.Show("Transakcija provedena!");
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
