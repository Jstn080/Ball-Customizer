using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaktionslogik für _5.xaml
    /// </summary>
    public partial class _5 : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=ballcustomizer";
        #endregion
        public _5()
        {
            InitializeComponent();
            var a = (DataViewModel)MainFarben.DataContext;
            var uriSource = new Uri($@"pictures/{a.Ball}.png", UriKind.Relative);
            Farbenmarken.Source = (new BitmapImage(uriSource));
            var b = (DataViewModel)MainFarben.DataContext;
            var penis = new Uri($@"pictures/{b.Material}.png", UriKind.Relative);
            Farbenicons.Source = (new BitmapImage(penis));
            var d = (DataViewModel)MainFarben.DataContext;
            var herst = new Uri($@"pictures/{d.Marken}.png", UriKind.Relative);
            Farbenbilder.Source = (new BitmapImage(herst));
            ObservableCollection<Farbe> eintrag = new ObservableCollection<Farbe>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from farbe", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Farbe c = new Farbe((int)reader[0], (string)reader[1]);
                        eintrag.Add(c);
                    }
                }


                foreach (var item in eintrag)
                {
                    a.farbe.Add(item);
                }
            }
        }

        private void Farbencombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewModel)MainFarben.DataContext;
            var uriSource = new Uri($@"pictures/{Farbencombo.SelectedItem}.png", UriKind.Relative);
            Farbenfarben.Source = (new BitmapImage(uriSource));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = (DataViewModel)Farbencombo.DataContext;
            a.Farben = Farbencombo.SelectedItem.ToString();
            new _6().Show();
            this.Close();
        }
    }
}
