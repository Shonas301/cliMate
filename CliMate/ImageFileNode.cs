using Climate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliMate
{
    public class ImageFileNode : InputNode
    {
        public Bitmap image;
        public Heightmap heightmap;

        public ImageFileNode(NodeMap map, String fileName) : base(map)
        {
            image = new Bitmap(fileName);
            heightmap = new Heightmap(image);

        }

        public ImageFileNode(NodeMap map, Heightmap heightmap) : base(map)
        {
            //Creates one from a pre-existing heightmap.

            image = heightmap.ToBitmap();
            this.heightmap = heightmap;
        }

        public override Bitmap ToBitmap() {
            return heightmap.ToBitmap();
        }

        public override void doOperation()
        {
            //TODO Slap the file import logic here and put it into the output grid
            throw new NotImplementedException();
        }
    }
}