using System.IO;
using System.Windows;

namespace WpfDataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // DG.ItemsSource = Songs.GetSongs();
        }
    }

    public class Songs
    {
        public List<Song> SongList { get; set; } = GetSongs();
        public static List<Song> GetSongs()
        {
            var file = @"C:\Users\7dugo\Desktop\make-wpf\Learn\Sample\DataGrid\WpfDataGrid\WpfDataGrid\bin\Debug\net7.0-windows\songs.csv";
            var lines = File.ReadAllLines(file);
            var list = new List<Song>();
            for(int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Split(',');
                var g = line[2].Split(' ', '&', '-');
                var gr = g.Length > 1 ? g[0] + g[1] : g[0];
                var song = new Song()
                {
                    Id = int.Parse(line[0]),
                    Title = line[1].Trim(),
                    Artist = line[3].Trim(),
                    IsSoundTrack = line[4].Trim() == "Unknown" ? false : true,
                    MovieTitle = line[4].Trim(),
                    Genre = (Genre)Enum.Parse(typeof(Genre), gr),
                    ReleaseYear = DateTime.Parse(line[5]+",01,01"),
                    URL = new Uri($"www.{line[3].Trim()}.com", UriKind.Relative),
                };
                list.Add(song);
            }
            return list;
        }
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
    }

    public enum Genre
    {
        HeavyMetal,HardRock,SoftRock,ClassicRock,Rock,Pop,PopSoul,Blues,Jazz,RB,Country,Folk,Funk,ChristmasCarol
    }
}