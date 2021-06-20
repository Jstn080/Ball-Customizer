using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Customizer
{
    class DataViewModel
    {
        public ObservableCollection<Ball> Baelle { get; set; } = new ObservableCollection<Ball>();
        public ObservableCollection<Muster> muster { get; set; } = new ObservableCollection<Muster>();
        public ObservableCollection<Farbe> farbe { get; set; } = new ObservableCollection<Farbe>();
        public ObservableCollection<Marke> marke { get; set; } = new ObservableCollection<Marke>();
        public ObservableCollection<Material> material { get; set; } = new ObservableCollection<Material>();
        public string Ball { get; set; }
        public string Material { get; set; }
        public string Marken { get; set; }
        public string Farben { get; set; }
    }
}
