using System.Xml;

namespace XMLDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateXMLFile();
            Console.ReadLine();
        }

        static void CreateXMLFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("MOVIES");
            doc.AppendChild(root);
            doc.Save(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\XMLDemoApp\\XMLDemoApp\\movies.cs");
            System.Console.WriteLine(doc.InnerXml);
        }
    }
}