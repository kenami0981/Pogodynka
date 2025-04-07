using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pogodynka.Model
{
    internal class CapitalsCollection : ObservableCollection<Capitals>
    {
        public CapitalsCollection() {
            Add(new Capitals { Name = "Warszawa" });
            Add(new Capitals { Name = "Moskwa" });
            Add(new Capitals { Name = "Berlin"});
            Add(new Capitals { Name = "Madryt" });
            Add(new Capitals { Name = "Rzym" });
            Add(new Capitals { Name = "Paryż" });
            Add(new Capitals { Name = "Wiedeń" });
            Add(new Capitals { Name = "Bukareszt" });
            Add(new Capitals { Name = "Budapeszt" });
            Add(new Capitals { Name = "Londyn" });
            Add(new Capitals { Name = "Kijów" });
            Add(new Capitals { Name = "Belgrad" });
            Add(new Capitals { Name = "Sofia" });
            Add(new Capitals { Name = "Praga" });
            Add(new Capitals { Name = "Mińsk" });
            Add(new Capitals { Name = "Ateny" });
            Add(new Capitals { Name = "Skopije" });
            Add(new Capitals { Name = "Tirana" });
            Add(new Capitals { Name = "Ryga" });
            Add(new Capitals { Name = "Wilno" });
            Add(new Capitals { Name = "Zagrzeb" });
            Add(new Capitals { Name = "Oslo" });

        }

    }
}
