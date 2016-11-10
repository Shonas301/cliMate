using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace CliMate
{
    //I figure this'll be a superclass at some point if we want tiles to hang on to other data such as wind vectors or something.
    public class Tile
    {
        private Color color;

        public Tile(Color color)
        {
            this.color = color;
        }

        public Color getColor()
        {
            return color;
        }
        public void setColor(Color color)
        {
            this.color = color;
        }
    }
}