using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliMate
{
    public partial class GeneratePerlinForm : Form
    {
        private Heightmap previewMap;

        public GeneratePerlinForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Get the data from the textboxes
            int width;
            int height;
            int seed;

            //Catch any errors with the textboxes
            try
            {
                width = int.Parse(widthBox.Text);
                height = int.Parse(heightBox.Text);
                seed = int.Parse(seedBox.Text);
            }
            catch (FormatException err)
            {
                MessageBox.Show("ERROR: width, height, and seed must all be integers.");
                return;
            }
            catch (OverflowException err)
            {
                MessageBox.Show("ERROR: either width, height, or seed are too long.");
                return;
            }

            //Generate the preview map
            previewMap = new Heightmap(width, height);
            PerlinNoise noiseGen = new PerlinNoise(seed);
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double value = noiseGen.GetValue((double)x, (double)y) * Heightmap.MAX_HEIGHT;
                    previewMap.SetValue(x, y, value);
                }
            }

            //Update the preview picture
            previewBox.Image = previewMap.ToBitmap();

            //Enable the Okay button
            OKButton.Enabled = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Update the project's heightmap
            Form1.currentOpenProject.heightOverlay.contents = previewMap;
            this.Close();
        }
    }
}
