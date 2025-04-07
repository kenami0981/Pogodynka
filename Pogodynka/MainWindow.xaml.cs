using Pogodynka.Model;
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

namespace Pogodynka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CapitalsCollection _capitals = new CapitalsCollection();
        public MainWindow()
        {
            
            InitializeComponent();
            cb_capitals.ItemsSource = _capitals;


            
            
        }
        private async void SprawdzPogode_Click(object sender, RoutedEventArgs e)
        {
            var api = new ApiClient();
            string json = await api.GetWeatherData("Warszawa");
            Display_json.Text = json;
        }
    }
}
