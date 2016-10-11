using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace CliMate
{
    class Tile
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
