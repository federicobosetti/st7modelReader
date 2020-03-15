using System;
using st7modelReader;


namespace st7modelReader
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ciao polletto!");

            string fileName = @"C:\dev\code\st7modelReader\data\model01.txt";

            fileLoader loader = new fileLoader();
            
            loader.filename = fileName;

            loader.load();

        }
    }
}
