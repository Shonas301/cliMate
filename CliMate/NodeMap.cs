using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    public class NodeMap
    {
        //This will store a Graph of nodes
        //I say "graph" and not "tree" because we should allow for free-floating nodes and sub-trees
        //What we export when the user decides to export will be whatever is in the node "output" 
        private Node output;
        List<Node> Nodes;
        public int outHeight { get; set; }
        public int outWidth { get; set; }

        public NodeMap()
        {
            //output = new OutputNode(this);
            Nodes = new List<Node>();
            //Nodes.Add(output);
        }
        public void AddNode(Node n)
        {
            Nodes.Add(n);
        }
        public Node GetNode(int n)
        {
            return Nodes.ElementAt(n);
        }
        public Node GetLastNode()
        {
            return Nodes.Last();
        }

        public int GetNum() {
            return Nodes.Count;
        }
    }
}