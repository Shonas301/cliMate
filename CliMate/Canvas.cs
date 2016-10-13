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
    public partial class Canvas : Form
    {
        private Heightmap workingMap = new Heightmap(100,100);

        public Canvas()
        {
            InitializeComponent();
        }

        private void Canvas_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picbox_MouseMove);
        }

        private void refresh_timer_Tick(object sender, EventArgs e)
        {

        }

        private void Picbox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Keep the coordinates within bounds
                int x = e.X % workingMap.width;
                int y = e.Y % workingMap.height;

                //Set the value at this pixel to black
                workingMap.SetValue(x, y, 100);

                //Update the picture box
                pictureBox1.Image = workingMap.ToBitmap();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //DONT PUT ANYTHING HERE
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Form1.currentOpenProject.heightOverlay.contents = workingMap;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
