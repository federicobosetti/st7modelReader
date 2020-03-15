using st7modelReader;
using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            fileLoader loader = new fileLoader();
            loader.load();


        }
    }
}
