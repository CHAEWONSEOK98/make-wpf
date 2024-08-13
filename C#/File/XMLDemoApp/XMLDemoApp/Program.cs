using System.Xml;

namespace XMLDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateXMLFile();
            //AddRecordToXML();
            //ReadRecords();
            UpdateRecord();
            Console.ReadLine();
        }

        static void UpdateRecord()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\XMLDemoApp\\XMLDemoApp\\movies.xml");
            XmlNode targetNode = doc.SelectSingleNode("MOVIES/MOVIE[@id=1]/TITLE");
            targetNode.InnerText = "Goodfellas";

            doc.Save(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\XMLDemoApp\\XMLDemoApp\\movies.xml");
            Console.WriteLine(doc.InnerXml);
        }

        static void ReadRecords()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\XMLDemoApp\\XMLDemoApp\\movies.xml");
            XmlNodeList nodes = doc.SelectNodes("MOVIES/MOVIE");
            foreach (XmlNode node in nodes)
            {
                Console.WriteLine($"{node.Attributes[0].Value} {node.ChildNodes[0].InnerText}");
            }
        }

        static void AddRecordToXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\XMLDemoApp\\XMLDemoApp\\movies.xml");
            XmlNode root = doc.SelectSingleNode("MOVIES");
            XmlElement movie = doc.CreateElement("MOVIE");
            root.AppendChild(movie);

            XmlAttribute id = doc.CreateAttribute("id");
            id.Value = doc.SelectNodes("MOVIES/MOVIE").Count.ToString();
            movie.Attributes.Append(id);

            XmlElement title = doc.CreateElement("TITLE");
            title.InnerText = "Lord Of The Rings";
            movie.AppendChild(title);
            doc.Save(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\XMLDemoApp\\XMLDemoApp\\movies.xml");
            Console.WriteLine(doc.InnerXml);
        }

        static void CreateXMLFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("MOVIES");
            doc.AppendChild(root);
            doc.Save(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\XMLDemoApp\\XMLDemoApp\\movies.xml");
            System.Console.WriteLine(doc.InnerXml);
        }
    }
}