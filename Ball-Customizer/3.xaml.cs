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
    /// Interaktionslogik für _3.xaml
    /// </summary>
    public partial class _3 : Window
    {
        #region connectionstring
        const string connectionString = "server=localhost;uid=root;database=ballcustomizer";
        #endregion
        public _3()
        {
            InitializeComponent();
            var a = (DataViewModel)MainMaterial.DataContext;
            var uriSource = new Uri($@"pictures/{a.Ball}.png", UriKind.Relative);
            Materialicons.Source = (new BitmapImage(uriSource));

            ObservableCollection<Material> eintrag = new ObservableCollection<Material>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // connect
                connection.Open();

                // command
                MySqlCommand cmd = new MySqlCommand("select * from material", connection);

                // read result
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Material c = new Material((int)reader[0], (string)reader[1]);
                        eintrag.Add(c);
                    }
                }

                
                foreach (var item in eintrag)
                {
                    a.material.Add(item);
                }
            }
        }

        private void Materialcombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (DataViewModel)MainMaterial.DataContext;
            var uriSource = new Uri($@"pictures/{Materialcombo.SelectedItem}.png", UriKind.Relative);
            Materialbilder.Source = (new BitmapImage(uriSource));
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = (DataViewModel)MainMaterial.DataContext;
            a.Material = Materialcombo.SelectedItem.ToString();
            new _4().Show();
            this.Close();
        }
    }
}
