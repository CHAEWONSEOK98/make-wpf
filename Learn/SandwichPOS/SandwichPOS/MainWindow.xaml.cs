using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace SandwichPOS
{
    public partial class MainWindow : Window
    {
        public List<Sandwich> SandwichList { get; set; } = XMLData.GetSandwiches();
        public List<Veggie> VeggieList { get; set; } = XMLData.GetVeggies();
        public List<Cheese> CheeseList { get; set; } = XMLData.GetCheeses();
        public MainWindow()
        {
            InitializeComponent();
            //XMLData.CreateFiles();
            //XMLData.GetSandwiches();
            //XMLData.GetVeggies();
            //XMLData.GetCheeses();
            //XMLData.RecordOrder(new Order() { orderTotal = 1.99M });
            //XMLData.RecordPayment(new Payment() { orderId=1, amountPaid = 1.99M });
        }

        decimal Total = 0.0M;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var item = btn.DataContext as Sandwich;
            lbxORDER.Items.Add(item);
            if(lbxORDER.Items.Count > 0 )
            {
                Total += item.price;
                tblTOTAL.Text = Total.ToString("c");
            }
        }

        private void btnTENDER_Click(object sender, RoutedEventArgs e)
        {
            decimal tenderedAmount = decimal.Parse(tbxTENDER.Text);
            Order o = new Order() { orderTotal = Total };
            Payment p = new Payment() { orderId = XMLData.GetOrderID(), amountPaid = tenderedAmount };
            XMLData.RecordOrder(o);
            XMLData.RecordPayment(p);
            tblTOTAL.Text = (Total - tenderedAmount).ToString("c");
            tbxTENDER.Text = "";
            lbxORDER.Items.Clear();
        }

        private void btnCLEAR_Click(object sender, RoutedEventArgs e)
        {
            tblTOTAL.Text = "$0.00";
        }
    }

    public static class XMLData
    {
        public static void RecordPayment(Payment o)
        {
            string file = "payment.xml";
            var xdoc = XDocument.Load(file);
            var id = xdoc.Root.Descendants().Count() + 1;
            var xelement = new XElement("Payment", new XAttribute("id", id),
                new XAttribute("timeStamp", DateTime.Now.ToString()), 
                new XAttribute("orderId", o.orderId),
                new XAttribute("amountPaid", o.amountPaid));
            xdoc.Root.Add(xelement);
            xdoc.Save(file);
        }

        public static int GetOrderID()
        {
            string file = "order.xml";
            var xdoc = XDocument.Load(file);
            var id = xdoc.Root.Descendants().Count() + 1;
            return id;
        }

        public static void RecordOrder(Order o)
        {
            string file = "order.xml";
            var xdoc = XDocument.Load(file);
            var id = xdoc.Root.Descendants().Count() + 1;
            var xelement = new XElement("Order", new XAttribute("id", id), new XAttribute("orderTotal", o.orderTotal));
            xdoc.Root.Add(xelement);
            xdoc.Save(file);
        }

        public static List<Cheese> GetCheeses()
        {
            var xdoc = XDocument.Load("cheese.xml");
            var list = xdoc.Root.Descendants("Cheese").Select(x => new Cheese()
            {
                id = int.Parse(x.Attribute("id").Value),
                name = x.Attribute("name").Value,
                img = @"\Images\" + x.Attribute("img").Value
            }).ToList();
            return list;
        }

        public static List<Veggie> GetVeggies()
        {
            //var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var xdoc = XDocument.Load("veggie.xml");
            var list = xdoc.Root.Descendants("Veggie").Select(x => new Veggie()
            {
                id = int.Parse(x.Attribute("id").Value),
                name = x.Attribute("name").Value,
                img = @"\Images\" + x.Attribute("img").Value
            }).ToList();
            return list;
        }

        public static List<Sandwich> GetSandwiches()
        {
            //var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var xdoc = XDocument.Load("sandwich.xml");
            var list = xdoc.Root.Descendants("Sandwich").Select(x => new Sandwich()
            {
                id = int.Parse(x.Attribute("id").Value),
                name = x.Attribute("name").Value,
                price = decimal.Parse(x.Attribute("price").Value),
                img =  @"\Images\" + x.Attribute("img").Value
            }).ToList();
            return list;
        }

        public static void CreateFiles()
        {
            string[] files = { "payment", "order", "veggie", "cheese", "sandwich" };
            foreach (string file in files)
            {
                var xdoc = new XDocument();
                xdoc.Add(new XElement("root"));
                xdoc.Save(file + ".xml");
            }
        }
    }

    #region Classes Sandwich, Veggie, Cheese, Order, Payment

    public class Sandwich
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string img { get; set; }
    }

    public class Veggie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { set; get; }
    }

    public class Cheese
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { set; get; }
    }

    public class Order
    {
        public int id { get; set; }
        public decimal orderTotal { get; set; }
    }

    public class Payment
    {
        public int id { get; set; }
        public DateTime timeStamp { get; set; }
        public int orderId { get; set; }
        public decimal amountPaid { get; set; }
    }
    #endregion

}