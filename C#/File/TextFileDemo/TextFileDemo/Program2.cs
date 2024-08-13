namespace TextFileDemo
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Write();
            //Append();
            Read();
            Console.ReadLine();
        }

        const string filename = "example2.txt";
        static void Write()
        {
            //string str = "part-2";
            //File.WriteAllText(filename, str);

            string[] strArray = { "Creates the file", "writes the content", "Closes the file", "if exists then overwrites" };
            File.WriteAllLines(filename, strArray);
        }

        static void Append()
        {
            //string content = "Opens the file, Writes to the file, Closes the file; " +
            //    "If does not exist, it creates the file, then writes, then closes";
            //File.AppendAllText(filename, content);

            string[] contents = {"Opens the file,", "Writes to the file in lines,", "Closes the file;",
            "If does not exist,", "it creates the file,", "then writes, then closes"};
            File.AppendAllLines(filename, contents);
        }

        static void Read()
        {
            try
            {
                //string content = File.ReadAllText(filename);
                //Console.WriteLine(content);

                string[] lines = File.ReadAllLines(filename);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(i + " " + lines[i]);
                }
            }   
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                File.AppendAllText("errors.txt",DateTime.Now + " " + ex.Message);
            }
        }
    }
}
