using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfCustomDataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        const string file = @"C:\Users\7dugo\Desktop\images\DataGrid\Songs.csv";

        #region DataGrid CRUD Events
        // Add, Update Event
        private void GRD_RowEditEnding(object sender, System.Windows.Controls.DataGridRowEditEndingEventArgs e)
        {
            Song newsong = e.Row.DataContext as Song;
            var numOfSongsInFile = File.ReadAllLines(file).Length;
            if (numOfSongsInFile < Songs.SongList.Count)
            {
                AddNewSong(newsong);
            }
            else
            {
                UpdateSong();
            }
        }

        // Delete Event
        private void GRD_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var source = e.OriginalSource.GetType().Name;
            if (e.Key == Key.Delete && source == "DataGridCell")
            {
                var song = GRD.SelectedItem as Song;
                var result = MessageBox.Show("Are You Sure?", "Delete Song", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                {
                    DeleteSong(song);
                }
            }
        }
        #endregion

        #region DataGrid CRUD Method
        void AddNewSong(Song s)
        {
            File.AppendAllText(file, $"\n{s.Id},{s.Title},{s.Genre},{s.Artist},{s.MovieTitle},{s.ReleaseYear.Year},{s.URL}");
        }

        void UpdateSong()
        {
            string lines = "";
            foreach (var s in Songs.SongList)
            {
                lines += $"{s.Id},{s.Title},{s.Genre},{s.Artist},{s.MovieTitle},{s.ReleaseYear.Year},{s.URL}\n";
            }
            File.WriteAllText(file, lines);
        }

        void DeleteSong(Song song)
        {
            string lines = "";
            foreach (var s in Songs.SongList)
            {
                if (s.Id != song.Id)
                {
                    lines += $"{s.Id},{s.Title},{s.Genre},{s.Artist},{s.MovieTitle},{s.ReleaseYear.Year},{s.URL}\n";
                }
            }
            File.WriteAllText(file, lines);
        }

        #endregion

        // DataGrid Filter Event
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var tbx = sender as TextBox;
            if(tbx.Text != "")
            {
                var filteredList = Songs.SongList.Where(x => x.Title.ToLower().Contains(tbx.Text.ToLower()));
                GRD.ItemsSource = null;
                GRD.ItemsSource = filteredList;
            }
        }

        // DataGrid Create Event
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataGrid dg = new DataGrid();
            dg.ItemsSource = Songs.SongList;
            STKPNL.Children.Add(dg);
        }
    }

    public class Songs
    {
        public static List<Song> SongList { get; set; } = GetSongs();
        public static List<Song> GetSongs()
        {
            var file = @"C:\Users\7dugo\Desktop\images\DataGrid\Songs.csv";
            var lines = File.ReadAllLines(file);
            var list = new List<Song>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Split(',');
                var g = line[2].Split(' ', '&', '-');
                var gr = g.Length > 1 ? g[0] + g[1] : g[0];
                List<Artist> artists = new List<Artist>();
                if (line.Length > 6)
                {
                    for (int j = 6; j < line.Length; j++)
                    {
                        var artist = new Artist() { Name = line[j] };
                        artists.Add(artist);
                    }
                }

                var song = new Song()
                {
                    Id = int.Parse(line[0]),
                    Title = line[1].Trim(),
                    Artist = line[3].Trim(),
                    IsSoundTrack = line[4].Trim() == "Unknown" ? false : true,
                    MovieTitle = line[4].Trim(),
                    Genre = (Genre)Enum.Parse(typeof(Genre), gr),
                    ReleaseYear = DateTime.Parse(line[5] + ",01,01"),
                    URL = new Uri($"www.{line[3].Trim()}.com", UriKind.Relative),
                    Artists = artists,
                };
                list.Add(song);
            }
            return list;
        }
    }

    public class Artist
    {
        public string Name { get; set; }
    }

    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public bool IsSoundTrack { get; set; }
        public string MovieTitle { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseYear { get; set; }
        public Uri URL { get; set; }
        public List<Artist> Artists { get; set; }
    }

    public enum Genre
    {
        HeavyMetal, HardRock, SoftRock, ClassicRock, Rock, Pop, PopSoul, Blues, Jazz, RB, Country, Folk, Funk, ChristmasCarol
    }
}