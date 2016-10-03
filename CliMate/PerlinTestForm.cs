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
            Heightmap map = new Heightmap(100, 100);

            for (int x = 0; x < map.width; x++)
            {
                for (int y = 0; y < map.height; y++)
                {
                    double height = generator.GetValue(x, y) * Heightmap.MAX_HEIGHT;
                    Console.WriteLine(height);
                    map.SetValue(x, y, height);
                }
            }

            //Display the bitmap
            picBox.Image = map.ToBitmap();
        }

        private void PerlinTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
