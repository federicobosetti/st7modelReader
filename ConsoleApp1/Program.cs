using System;
using modelDefinition;
using st7modelReader;


namespace st7modelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model01;

            Console.WriteLine("ciao polletto!");

            string fileName = @"C:\dev\code\st7modelReader\data\model01.txt";

            fileLoader loader = new fileLoader();
            
            loader.filename = fileName;

            model01 = loader.load();

            Console.WriteLine("numero di nodi nel modello = "+model01.getNodesNumber());
            
            for (int i=0;i< model01.Nodes.Count;i++ )
            {
                Console.WriteLine(model01.Nodes[i].number + "_" + model01.Nodes[i].x + "_" + model01.Nodes[i].y+"_"+ model01.Nodes[i].z);


            }
            


        }
    }
}
