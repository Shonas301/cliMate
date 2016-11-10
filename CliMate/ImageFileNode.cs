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

        new public Bitmap ToBitmap() {
            return heightmap.ToBitmap();
        }

        public override void doOperation()
        {
            //TODO Slap the file import logic here and put it into the output grid
            throw new NotImplementedException();
        }
    }
}