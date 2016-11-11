using CliMate;
using System;

namespace Climate
{
    [Serializable]
    public abstract class InputNode : Node
    {
        //Parent class for generation things
        //subclass of normal nodes
        //start of the chain type deal
        public InputNode(NodeMap map) : base()
        {
            outGrid = new RectGrid(map.outHeight, map.outWidth);
        }

        //you are not allowed to set kiddos. bad. no kiddos
        public override void setInputNode(Node kiddo)
        {
            return;
        }
    }
}
