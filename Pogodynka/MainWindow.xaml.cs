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
            //Sprawdzanie czy dane zostały wpisane
            if (cb_capitals.SelectedItem != null)
            {
                city = cb_capitals.SelectedItem.ToString();
                cb_capitals.Text = null;
            }
            else if (cb_capitals.Text != "") { 
                city = cb_capitals.Text;
                cb_capitals.Text = null;
            }
            else
            {
                return;
            }

            var json = await api.GetWeatherData(city);
            //Zabezpieczenie przed wpisaniem nieistniejącego miasta
            if (json == null) {
                MessageBox.Show("Wprowadź poprawne dane");
                return; 
            }
            // Wyświetlanie danych pogodowych
            WeatherInfo.Visibility = Visibility.Visible;
            Display_city.Text = $"{city}";
            Display_temperature.Text = $"Temperatura:";
            Display_temperature_value.Text = $"{json.Main.temperature.ToString()}°C";
            Display_humidity.Text += $"Wilgotoność:";
            Display_humidity_value.Text = $"{json.Main.humidity.ToString()}%";
            Display_pressure.Text += $"Ciśnienie atmosferyczne:";
            Display_pressure_value.Text = $"{json.Main.pressure.ToString()} hPa";
            Display_describe.Text += $"Opis:";
            Display_describe_value.Text = $"{json.WeatherD[0].Description.ToString()}";

        }
    }
}
