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
    /// Interaktionslogik für _2.xaml
    /// </summary>
    public partial class _2 : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=ballcustomizer";
        #endregion
        public _2()
        {
            InitializeComponent();
            ObservableCollection<Ball> eintrag = new ObservableCollection<Ball>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from ball", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ball c = new Ball((int)reader[0], (string)reader[1], (string)reader[2]);
                        eintrag.Add(c);
                    }
                }

                var a = (DataViewModel)MainBallart.DataContext;
                foreach (var item in eintrag)
                {
                    a.Baelle.Add(item);
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var uriSource = new Uri($@"pictures/{Ballarten.SelectedItem}.png", UriKind.Relative);
            Ballbilder.Source = (new BitmapImage(uriSource));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var v = (DataViewModel)MainBallart.DataContext;
            v.Ball = Ballarten.Text;
            new _3().Show();
            this.Close();
        }
    }
}
