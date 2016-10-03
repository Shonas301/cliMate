using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpNoise.Modules;

namespace CliMate
{
    public partial class PerlinTestForm : Form
    {
        public PerlinTestForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Set up the generator
            PerlinNoise generator = new PerlinNoise((int)(seedBox.Value));

            //Generate a heightmap
            Bitmap map = new Bitmap(100, 100);

            for (int x = 0; x < map.Width; x++)
            {
                for (int y = 0; y < map.Height; y++)
                {
                    double height = generator.GetValue(x, y) * 100;
                    int intHeight = (int)height % 255;
                    //Console.WriteLine(height);
                    map.SetPixel(x, y, Color.FromArgb(intHeight, intHeight, intHeight));
                }
            }

            //Display the bitmap
            picBox.Image = map;
        }
    }
}
