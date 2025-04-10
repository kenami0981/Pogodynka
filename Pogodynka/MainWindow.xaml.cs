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
            string city = null;
            if (cb_capitals.SelectedItem != null)
            {
                city = cb_capitals.SelectedItem.ToString();
                cb_capitals.Text = null;
            }
            else if (tb_capital.Text != "")
            {
                city = tb_capital.Text;
                tb_capital.Text = "";
            }
            else {
                return;
            }
                var json = await api.GetWeatherData(city);
            //if (json == "Błąd: NotFound") {
            //    Display_json.Text = "Nieporawne miasto";
            //    return; }

            Display_json.Text = $"Temperatura: {json.Main.temperature.ToString()}\n";
            Display_json.Text += $"Wilgotoność: {json.Main.humidity.ToString()}\n";
            Display_json.Text += $"Ciśnienie atmosferyczne: {json.Main.pressure.ToString()}\n";
            Display_json.Text += $"Opis: {json.WeatherD[0].Description.ToString()}\n";
        }
    }
}
