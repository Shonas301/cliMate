using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Climate;

namespace CliMate
{
    public class TempNode : InputNode
    {
        private float latWeight;


        public TempNode(NodeMap map, float latWeight) : base(map)
        {
            this.latWeight = latWeight;
        }

        public TempNode(NodeMap map) : base(map)
        {
            this.latWeight = 0.3f;
        }

        public override void doOperation()
        {
            if (children[0] != null)
            {
                float latVal;
                float heightVal;
                float tempVal;
                for (int x = 0; x < map.outWidth; x++)
                {
                    for (int y = 0; y < map.outHeight; y++)
                    {
                        latVal = y / map.outHeight;
                        heightVal = children[0].getOutputGrid().getTile(x, y).Value;
                        tempVal = latWeight * latVal + (1.0f - latWeight) * heightVal;
                        this.outGrid.setTile(x, y, tempVal);
                    }
                }
            }
        }
    }
}
