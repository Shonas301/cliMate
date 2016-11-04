using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    class MapNode
    {
        private Grid gridOut;
        private MapNode output;
        private MapNode[] inputs;
        private int nInputs;
        private int nodeType;
        private Point topLeft;
        private int nodeW;
        private int nodeH;

        public MapNode(int type, Point tl, int width, int height)
        {
            this.output = null;
            if (type == 1)
            {
                this.inputs = new MapNode[1];
            }
            else if (type == 2)
            {
                this.inputs = new MapNode[2];
            }
            else if (type == 3)
            {
                this.inputs = new MapNode[3];
            }
            this.nInputs = 0;
            this.nodeType = type;
            this.topLeft = tl;
            this.nodeW = width;
            this.nodeH = height;
        }

        public Point GetTopLeft()
        {
            return this.topLeft;
        }

        public int GetWidth()
        {
            return this.nodeW;
        }

        public int GetHeight()
        {
            return this.nodeW;
        }

    }
}
