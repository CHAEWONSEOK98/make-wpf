using System.IO;
using System.Windows;

namespace WpfCustomDataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Songs
    {
        public List<Song> SongList { get; set; } = GetSongs();
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