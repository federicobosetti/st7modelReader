using System;
using System.Collections.Generic;

namespace modelDefinition
{
    public class Model
    {
        public List<Node> Nodes = new List<Node>(); 

        public void addNode(Node node)
        {
            Nodes.Add(node);

        }


        public int getNodesNumber()
        {
            return Nodes.Count;

            
        }


    }



    public class Node
    {
        public long number;
        public string ID;
        public double x;
        public double y;
        public double z;
               
    }

    public class Beam
    {
        public long number;
        public string ID;
        public long node1;
        public long node2;
    }



}
