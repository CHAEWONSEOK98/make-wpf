namespace CSVFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // .CSV: comma seperated values
            AppendToCSV();
            ReadCSVFile();
            Console.ReadLine();
        }

        static void AppendToCSV()
        {
            var list = Contacts.GetContacts();
            foreach (var item in list)
            {
                File.AppendAllText("contacts.csv", $"{item.Name},{item.Phone}\n");
            }
        }

        static void ReadCSVFile()
        {
            var lines = File.ReadAllLines("contacts.csv");
            var list = new List<Contact>();

            foreach (var line in lines)
            {
                var values = line.Split(",");
                var contact = new Contact() { Name = values[0], Phone = values[1] };
                list.Add(contact);
            }
            list.ForEach(x => Console.WriteLine($"{x.Name}\t{x.Phone}"));
        }
    }

    public class Contacts
    {
        public static List<Contact> GetContacts()
        {
            return new List<Contact>()
            {
                new Contact(){Name="aill", Phone="333-444-5555"},
                new Contact(){Name="aane", Phone="666-444-1111"},
                new Contact(){Name="adill", Phone="777-444-2222"},
            };
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}