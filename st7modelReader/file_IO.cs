using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelDefinition;

namespace st7modelReader
{

    public class fileLoader
    {
        //public string path;
        public string filename;
        public Model load()
        {

            Model model01 = new Model();


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

                            node.number = Convert.ToInt64(split[1]);
                            node.ID = split[2];

                            node.x = Convert.ToDouble(split[3]);
                            node.y = Convert.ToDouble(split[4]);
                            node.z = Convert.ToDouble(split[5]);

                            node.x = double.Parse(split[3], CultureInfo.InvariantCulture);
                            node.y = double.Parse(split[4], CultureInfo.InvariantCulture);
                            node.z = double.Parse(split[5], CultureInfo.InvariantCulture);
                            
                            model01.addNode(node);

                            break;

                        case "Beam":


                            break;





                    }










                }


            }

            return model01;

        }

    }





}
