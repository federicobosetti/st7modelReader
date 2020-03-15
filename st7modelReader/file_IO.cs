using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelDefinition.Node;

namespace st7modelReader
{

    public class fileLoader
    {
        //public string path;
        public string filename;
        public void load()
        {

            foreach (var line in File.ReadLines(filename))
            {
                string[] split = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (split.Length > 0)
                {
                    Console.WriteLine(split[0]);
                    // process line

                switch (split[0]) {

                        case "Node":
                            Node node = new Node();

                            break;

                        case "Beam":


                            break;





                    }










                }


            }



        }

    }





}
