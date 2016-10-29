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
    class ImageFileNode : InputNode
    {
        public String FileName;
        public Bitmap image;

        public ImageFileNode(NodeMap map, String fileName) : base(map)
        {
            OpenFileDialog imageSelector = new OpenFileDialog();
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
                //System.Diagnostics.Debug.Write("\r\n" + fileName + "\r\n we did it \r\n");
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
                image = new Bitmap(fileName);

                //UpdateDisplay();
                //System.Diagnostics.Debug.Write("\r\n this line ran: currentOpenProject.heightOverlay.convertFromImage(fileName); \rn");
            }
            //TODO add "open/open recent" code;
        }

        public override void doOperation()
        {
            //TODO Slap the file import logic here and put it into the output grid
            throw new NotImplementedException();
        }
    }
}