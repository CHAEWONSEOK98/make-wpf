using Microsoft.Win32;
using System.Windows;

namespace CSV_DataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Csv Files| *.csv";

            //openFile.ShowDialog();

            if(openFile.ShowDialog() == true)
            {
                var csvData = CSVData.GetCsvData(openFile.FileName);

                CsvDataGrid.ItemsSource = csvData;
            }
        }
    }
}