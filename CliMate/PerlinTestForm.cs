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
        public const string TEST_FILE = "test.png";

        public Heightmap map = null;
     

        public PerlinTestForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Set up the generator
            PerlinNoise generator = new PerlinNoise((int)(seedBox.Value));

            //Generate a heightmap
            map = new Heightmap(100, 100);

            for (int x = 0; x < map.width; x++)
            {
                for (int y = 0; y < map.height; y++)
                {
                    double height = generator.GetValue(x, y) * Heightmap.MAX_HEIGHT;
                    //Console.WriteLine(height);
                    map.SetValue(x, y, height);
                }
            }

            //Display the bitmap
            picBox.Image = map.ToBitmap();
        }

        private void PerlinTestForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Find the highest value of perlin noise

            PerlinNoise generator = new PerlinNoise((int)(seedBox.Value));
            MessageBox.Show("" + generator.SearchMaxValue(999999, 0.1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Save the heightmap
            //map.ToBitmap().Save(TEST_FILE);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Load the heightmap
            //map = new Heightmap(new Bitmap(TEST_FILE));
            //picBox.Image = map.ToBitmap();
        }
    }
}
