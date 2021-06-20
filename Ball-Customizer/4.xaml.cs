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
    /// Interaktionslogik für _4.xaml
    /// </summary>
    public partial class _4 : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=ballcustomizer";
        #endregion
        public _4()
        {
            InitializeComponent();
            var a = (DataViewModel)MainMarken.DataContext;
            var uriSource = new Uri($@"pictures/{a.Ball}.png", UriKind.Relative);
            Markenmarken.Source = (new BitmapImage(uriSource));
            var b = (DataViewModel)MainMarken.DataContext;
            var penis = new Uri($@"pictures/{b.Material}.png", UriKind.Relative);
            Markenicons.Source = (new BitmapImage(penis));
            ObservableCollection<Marke> eintrag = new ObservableCollection<Marke>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from marke", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Marke c = new Marke((int)reader[0], (string)reader[1]);
                        eintrag.Add(c);
                    }
                }

                foreach (var item in eintrag)
                {
                    a.marke.Add(item);
                }
            }
        }

        private void MainMarke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewModel)MainMarken.DataContext;
            var uriSource = new Uri($@"pictures/{MainMarke.SelectedItem}.png", UriKind.Relative);
            Markenbilder.Source = (new BitmapImage(uriSource));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = (DataViewModel)MainMarken.DataContext;
            a.Marken = MainMarke.SelectedItem.ToString();
            new _5().Show();
            this.Close();
        }
    }
}
