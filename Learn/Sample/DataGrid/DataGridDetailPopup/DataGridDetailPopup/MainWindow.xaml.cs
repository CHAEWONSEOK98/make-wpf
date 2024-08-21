using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DataGridDetailPopup
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new[] {
                    new {
                        name = "Julian Delacruz",
                        phone = "(888) 851-3927",
                        email = "a@hotmail.net",
                        address = "Ap #407-3381 Nulla. Rd.",
                        country = "Pakistan"
                    },
                    new {
                        name = "Cameron Benton",
                        phone = "1-397-415-7247",
                        email = "non.justo.proin@aol.ca",
                        address = "7041 Natoque Rd.",
                        country = "Poland"
                    },
                    new {
                        name = "Otto Singleton",
                        phone = "1-707-568-8634",
                        email = "curabitur.sed@google.org",
                        address = "240-8670 Eget, Road",
                        country = "Poland"
                    },
                    new {
                        name = "Shafira Mayo",
                        phone = "(624) 543-3746",
                        email = "nec@icloud.couk",
                        address = "Ap #287-7403 Sodales Ave",
                        country = "South Korea"
                    },
                    new {
                        name = "George Mullins",
                        phone = "1-724-790-1457",
                        email = "molestie@google.net",
                        address = "Ap #739-9362 Nam Rd.",
                        country = "Australia"
                    }
                            };

            MyGrid.ItemsSource = data;
        }

        private void DataGridRow_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                var row = e.Source as DataGridRow;

                DetailsWindow detailsWindow = new DetailsWindow(row.Item);
                detailsWindow.Owner = this;

                detailsWindow.Show();
            }
        }
    }
}