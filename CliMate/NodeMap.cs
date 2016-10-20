using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    class NodeMap
    {
        //This will store a Graph of nodes
        //I say "graph" and not "tree" because we should allow for free-floating nodes and sub-trees
        //What we export when the user decides to export will be whatever is in the node "output" 
        private Node output;
        int outWidth;
        int outHeight;
        List<Node> Nodes;

        NodeMap(Project p)
        {
            outWidth = p.getProjectWidth();
            outHeight = p.getProjectHeight();
            output = new OutputNode(this);
            Nodes = new List<Node>();
            Nodes.Add(output);
        }

        public void AddNode(Node n)
        {
            Nodes.Add(n);
        }

        public int getOutWidth() { return outWidth; }
        public int getOutHeight() { return outHeight; }
    }
}
