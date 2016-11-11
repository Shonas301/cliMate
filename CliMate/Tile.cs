using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace CliMate
{
    
    //I figure this'll be a superclass at some point if we want tiles to hang on to other data such as wind vectors or something.
    namespace CliMate {
        [Serializable]
        public class Tile
        {
            private float val;

            public float Value
            {
                get { return val; }
                set { val = value; }
            }


            public Tile(float val)
            {
                this.val = val;
            }

            public Color getColor()
            {
                int iVal = (int)(this.val * 255);
                return Color.FromArgb(iVal, iVal, iVal);
            }
        }
    }
}