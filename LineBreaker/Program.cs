using System;
using System.IO;

namespace LineBreaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\azatates\Documents\old.txt"))
            {
                int i = 0;
                do
                {
                    i++;
                    string line = ", " + sr.ReadLine();
                    if (line != "")
                    {
                        text = text + line + Environment.NewLine;
                    }
                } while (sr.EndOfStream == false);
            }
            File.WriteAllText(@"C:\Users\azatates\Documents\new.txt", text);
        }
    }
}
