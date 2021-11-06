using System;
using System.Collections.Generic;
using System.IO;

namespace Matura_5._2
{
    class Program
    {
        static String[][] readFile()
        {
            List<String[]> list = new List<String[]>();
            using (StreamReader reader = new StreamReader("pogoda.txt"))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] values = line.Split(';');
                    list.Add(values);
                }
            }
            return list.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
