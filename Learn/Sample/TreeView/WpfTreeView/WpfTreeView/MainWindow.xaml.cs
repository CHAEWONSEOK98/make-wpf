using System.IO;
using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace WpfTreeView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateTreeView();
        }

        #region 3rd ex
        private void CreateTreeView()
        {
            var category = new Category() { CategoryName = "Produce", SubCategories = new List<SubCategory>() };
            var subCategory = new SubCategory() { SubCategoryName = "Vegatables", Items = new List<Item>() };
            var item = new Item() { ItemName = "Tomato" };
            category.SubCategories.Add(subCategory);
            subCategory.Items.Add(item);

            TreeView t = new TreeView();
            TreeViewItem tv1 = new TreeViewItem();
            tv1.Header = category.CategoryName;

            TreeViewItem tv2 = new TreeViewItem();
            tv2.Header = subCategory.SubCategoryName;

            TreeViewItem tv3 = new TreeViewItem();
            tv3.Header = item.ItemName;

            tv1.Items.Add(tv2);
            tv2.Items.Add(tv3);
            t.Items.Add(tv1);
            MyDock.Children.Add(t);
        } 
        #endregion
    }
    #region 3rd ex
    public class Category
    {
        public string CategoryName { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }

    public class SubCategory
    {
        public string SubCategoryName { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string ItemName { get; set; }
    }
    #endregion

    #region 4st ex
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
    #endregion

    #region 5th ex

    public class Book
    {
        public string BookTitle { get; set; }
        public List<Chapter> Chapters { get; set; }
    }

    public class Chapter
    {
        public int PageNum { get; set; }
        public string ChapterTitle { get; set; }
        public List<Article> Articles { get; set; }
    }

    public class Article
    {
        public int PageNum { get; set; }
        public string ArticleTitle { get; set; }
    }

    public class Books
    {
        public List<Book> BookList { get; set; } = GetBooks();
        public static List<Book> GetBooks()
        {
            var listOfBooks = new List<Book>();
            var book1 = new Book()
            {
                BookTitle = "Book One",
                Chapters = new List<Chapter>()
                {
                    new Chapter()
                    {
                        PageNum = 10,
                        ChapterTitle = "Introduction"
                    },
                    new Chapter()
                    {
                        PageNum = 11,
                        ChapterTitle = "Chapter One",
                        Articles = new List<Article>()
                        {
                            new Article()
                            {
                                PageNum=12,
                                ArticleTitle="Article One"
                            }
                        }
                    }
                }
            };
            listOfBooks.Add(book1);
            var book2 = new Book()
            {
                BookTitle = "Book Two",
                Chapters = new List<Chapter>()
                {
                    new Chapter()
                    {
                        PageNum = 10,
                        ChapterTitle = "Introduction"
                    },
                    new Chapter()
                    {
                        PageNum = 11,
                        ChapterTitle = "Chapter One",
                        Articles = new List<Article>()
                        {
                            new Article()
                            {
                                PageNum=12,
                                ArticleTitle="Article One"
                            },
                                                        new Article()
                            {
                                PageNum=22,
                                ArticleTitle="Article Two"
                            }
                        }
                    }
                }
            };
            listOfBooks.Add(book2);
            return listOfBooks;
        }
    }
    #endregion

    #region 6th ex

    public class DIR
    {
        public DirectoryInfo DIRINFO { get; set; }
        public List<FILE> FILELIST { get; set; }
    }

    public class FILE
    {
        public FileInfo FILEINFO { get; set; }
    }

    public class Dirs
    {
        public List<DIR> DIRLIST { get; set; } = GetDRV();
        public static List<DIR> GetDRV()
        {
            var di = new DirectoryInfo(@"C:\Users\7dugo\Desktop\images\");
            var dirlist = new List<DirectoryInfo>(di.GetDirectories());

            var dirs = new List<DIR>();
            foreach (var dirinfo in dirlist)
            {
                var d = new DIR();
                d.DIRINFO = dirinfo;
                var x = new List<FILE>();
                foreach (var f in dirinfo.GetFiles())
                {
                    var fi = new FILE() { FILEINFO = f };
                    x.Add(fi);
                }
                d.FILELIST = x;
                dirs.Add(d);
            }
            return dirs;
        }
    }

    #endregion
}