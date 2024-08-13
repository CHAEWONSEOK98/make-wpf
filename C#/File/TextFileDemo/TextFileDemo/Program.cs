namespace TextFileDemo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Write();
        //    //Read();
        //    Append();
        //    Console.ReadLine();
        //}

        const string filename = "example.txt";

        static void Write()
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine("line 0");
            string s = "123456789a";
            sw.WriteLine(s);
            sw.Close();
        }

        static void Append()
        {
            StreamWriter sw = new StreamWriter(filename, true);
            for(int i = 0; i < 10; i++)
            {
                sw.Write(i);
            }
            sw.Close();
            Read();
        }

        static void Read()
        {
            StreamReader sr = new StreamReader(filename);
            //string s = sr.ReadLine();
            //while (sr.ReadLine() is string s)
            //{
            //    Console.WriteLine(s);
            //}
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
        }
    }
}