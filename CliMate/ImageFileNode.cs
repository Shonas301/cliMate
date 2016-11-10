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
            /*OpenFileDialog imageSelector = new OpenFileDialog();
            imageSelector.Filter = "Image Files(*.bmp,*.png ,*.jpg) | *.bmp; *png; *.jpg";
            imageSelector.Title = "Select an Image File";
            string sourceDir = @"remberence.txt";
            //sets the starting point
            if (File.Exists(sourceDir))
            {
                imageSelector.InitialDirectory = sourceDir;
            }
            else
            {
                imageSelector.InitialDirectory = @"C:\";
            }

            //press the OK button
            if (imageSelector.ShowDialog() == DialogResult.OK)
            {
                fileName = imageSelector.FileName;
                if (File.Exists(sourceDir))
                {
                    File.Delete(sourceDir);
                }
                File.WriteAllText(sourceDir, fileName);

                //sends filepath to height Overlay
                //currentOpenProject.FileName = fileName;
                //currentOpenProject.heightOverlay.convertFromImage(fileName);
                
                //Actual code to garnering the image
                //Greyscale it
                
            }
            //TODO add "open/open recent" code;
            */
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