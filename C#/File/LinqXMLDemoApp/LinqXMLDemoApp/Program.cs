using System.Xml.Linq;

namespace LinqXMLDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateXMLFile();
            //AddRecord();
            //ReadXMLFile();
            //Update();
            Delete();
            Console.ReadLine();
        }

        const string xmlfile = @"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\LinqXMLDemoApp\\LinqXMLDemoApp\\movies2.xml";

        static void Delete()
        {
            var xdoc = XDocument.Load(xmlfile);
            var targetNode = xdoc.Root.Descendants("MOVIE").FirstOrDefault(x => x.Attribute("id").Value == "3");
            targetNode.Remove();
            xdoc.Save(xmlfile);
            Console.WriteLine(xdoc);
        }

        static void Update()
        {
            var xdoc = XDocument.Load(xmlfile);

            //var targetNode = xdoc.Root.Descendants("MOVIE").FirstOrDefault(x => x.Attribute("id").Value == "3");
            //var title = targetNode.Descendants("TITLE").FirstOrDefault();
            //title.Value = "My Cousin Vinny";

            var title = xdoc.Root.Descendants("TITLE").FirstOrDefault(x => x.Value.StartsWith("Sc"));
            title.Value = "My Cousin Vinny";
            //title.Name = "DESCRIPTION";
            Console.WriteLine(xdoc);
            xdoc.Save(xmlfile);
        }

        static void ReadXMLFile()
        {
            XDocument xdoc = XDocument.Load(xmlfile);
            var xroot = xdoc.Root;
            var childNodes = xdoc.Root.Descendants("MOVIE");
            foreach (var item in childNodes)
            {
                Console.Write(item.Attribute("id").Value + " ");
                Console.WriteLine(item.Descendants("TITLE").FirstOrDefault().Value);
            }
            //Console.WriteLine(childNodes.FirstOrDefault(x => x.Attribute("id").Value == "2"));
        }

        static void AddRecord()
        {
            XDocument xdoc = XDocument.Load(xmlfile);
            //XElement xmovie = new XElement("MOVIE");
            //XAttribute xid = new XAttribute("id", 1);
            //XElement xtitle = new XElement("TITLE", "Star Wars");
            //xmovie.Add(xid);
            //xmovie.Add(xtitle);
            //xdoc.Root.Add(xmovie);
            string[] movies = { "Star Wars", "Avatar", "Scarface" };
            int i = 1;
            foreach (var movie in movies)
            {
                //XElement xmov = new XElement("MOVIE");
                //XAttribute xid = new XAttribute("id", i);
                //XElement xtitle = new XElement("TITLE", movie);
                //xmov.Add(xid);
                //xmov.Add(xtitle);
                XElement xmovie = new XElement("MOVIE",
                    new XAttribute("id", i),
                    new XElement("TITLE", movie));
                xdoc.Root.Add(xmovie);
                i++;
            }
            xdoc.Save(xmlfile);
            Console.WriteLine(xdoc);
        }

        static void CreateXMLFile()
        {
            XDocument xdoc = new XDocument();
            XElement xroot = new XElement("MOVIES");
            xdoc.Add(xroot);
            xdoc.Save(@"C:\\Users\\7dugo\\Desktop\\make-wpf\\C#\\File\\LinqXMLDemoApp\\LinqXMLDemoApp\\movies2.xml");
            Console.WriteLine(xdoc) ;
        }
    }
}