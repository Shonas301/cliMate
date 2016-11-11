using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    [Serializable]
    public abstract class Node
    {
        //I know it's bass ackwards, but the way we've been taught tree traversal led me to think it'd be best to consider output the root
        protected RectGrid outGrid;
        protected RectGrid mask;
        protected Node parent;
        protected Node[] children;
        protected bool enableMask;

        public Node()
        {
            enableMask = false;
            //This is here to make sure that setInput can always be called
            children = new Node[1];
        }

        public virtual void maskEnabled(bool enable) { enableMask = enable; }

        public abstract void doOperation();

        public virtual void setOutputNode(Node pops) { parent = pops; }

        public virtual void setInputNode(Node kiddo) { children[0] = kiddo; }
        
        public virtual Bitmap ToBitmap() { return null; }

        public RectGrid getOutputGrid() { return outGrid; }
    }
}