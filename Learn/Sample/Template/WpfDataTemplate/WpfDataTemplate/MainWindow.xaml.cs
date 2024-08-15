using System.Windows;

namespace WpfDataTemplate
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Products
    {
        public List<Product> MyProducts { get; set; } = GetProducts();
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Id=1, ProductName="Milk", Dep=Dep.Dairy },
                new Product(){Id=2, ProductName="Juice", Dep=Dep.Dairy },
                new Product(){Id=3, ProductName="Twizzlers", Dep=Dep.Candy },
                new Product(){Id=1, ProductName="Candy Bar", Dep=Dep.Candy },
                new Product(){Id=2, ProductName="Chips", Dep=Dep.Snack },
                new Product(){Id=3, ProductName="Gingerale", Dep=Dep.Soda },
            };
        }

        public Product Product { get; set; } = new Product()
        {
            Id = 20,
            ProductName = "Ice Cream"
        };
    }

    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Dep Dep { get; set; }
    }

    public enum Dep
    {
        Dairy,Snack,Candy,Soda
    }
}