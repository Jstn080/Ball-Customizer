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
using System.Windows.Shapes;

namespace Ball_Customizer
{
    /// <summary>
    /// Interaktionslogik für _6.xaml
    /// </summary>
    public partial class _6 : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=ballcustomizer";
        #endregion
        public _6()
        {
            InitializeComponent();
            var a = (DataViewModel)FinalProdukt.DataContext;
            var uriSource = new Uri($@"pictures/{a.Ball}.png", UriKind.Relative);
            Kyrie.Source = (new BitmapImage(uriSource));
            var b = (DataViewModel)FinalProdukt.DataContext;
            var penis = new Uri($@"pictures/{b.Material}.png", UriKind.Relative);
            Kevindurant.Source = (new BitmapImage(penis));
            var d = (DataViewModel)FinalProdukt.DataContext;
            var herst = new Uri($@"pictures/{d.Marken}.png", UriKind.Relative);
            Curry.Source = (new BitmapImage(herst));
            var f = (DataViewModel)FinalProdukt.DataContext;
            var kek = new Uri($@"pictures/{f.Farben}.png", UriKind.Relative);
            Joe.Source = (new BitmapImage(kek));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
