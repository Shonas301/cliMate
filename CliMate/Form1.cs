using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliMate
{
    public partial class Form1 : Form
    {
        public static Project currentOpenProject = new Project();

        private Form generatePerlinForm = new GeneratePerlinForm();

        private Form nodeInterfaceForm = new NodeInterface();

        Image img;

        int pic_previousX;
        int pic_previousY;
        int pan_previousX;
        int pan_previousY;

        private double ZOOMFACTOR = 1.25; 
        private int MINMAX = 3;

        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            //throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PerlinTestForm perlinForm = new PerlinTestForm();
            perlinForm.Show();
            //puts picturebox inside the panel so you can scroll
            outerPanel.Controls.Add(openTKPanel);
            openTKPanel.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //button for getting file
            //Opens file navigation window to select an image 
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
                string fileName = imageSelector.FileName;
                //System.Diagnostics.Debug.Write("\r\n" + fileName + "\r\n we did it \r\n");
                if (File.Exists(sourceDir))
                {
                    File.Delete(sourceDir);
                }
                File.WriteAllText(sourceDir, fileName);

                //sends filepath to height Overlay
                currentOpenProject.FileName = fileName;
                currentOpenProject.heightOverlay.convertFromImage(fileName);
                UpdateDisplay();
                //System.Diagnostics.Debug.Write("\r\n this line ran: currentOpenProject.heightOverlay.convertFromImage(fileName); \rn");
            }
        }

        private void openRecentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string recent = @"remberence.txt";
            if (!File.Exists(recent))
            {
                MessageBox.Show("No recent files to open!");
            }
            else
            {
                string fileName;
                System.IO.StreamReader file = new System.IO.StreamReader(recent);
                fileName = file.ReadLine();
                currentOpenProject.FileName = fileName;
                currentOpenProject.heightOverlay.convertFromImage(fileName);
                //System.Diagnostics.Debug.Write("\r\n" + fileName + "\r\n we did it \r\n");
                UpdateDisplay();
            }
        }
        private void UpdateDisplay()
        {
            img = currentOpenProject.heightOverlay.ToBitmap();
            openTKPanel.BackgroundImageLayout = ImageLayout.Stretch;
            openTKPanel.BackgroundImage = img;

        }

        private void generateNewMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generatePerlinForm.ShowDialog();
            UpdateDisplay();
        }

        private void heightmapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Canvas c = new Canvas();
            c.ShowDialog();
            UpdateDisplay();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nodeMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nodeInterfaceForm.ShowDialog();
            UpdateDisplay();
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            if (currentOpenProject.notes == null)
            {
                MessageBox.Show("Sorry no project loaded yet!", "Error");
                return;
            }
            NoteForm nF = new NoteForm(currentOpenProject.notes);
            nF.ShowDialog();
        }

        //zooms in picture

        //taken from https://social.msdn.microsoft.com/Forums/windows/en-US/50ea6adc-52cf-491a-bb99-729ac83475ce/mousewheel-zoom?forum=winforms
        private void ZoomIn()
        {
            if ((openTKPanel.Width < (MINMAX * outerPanel.Width)) &&
                (openTKPanel.Height < (MINMAX * outerPanel.Height)))
            {
                openTKPanel.Width = Convert.ToInt32(openTKPanel.Width * ZOOMFACTOR);
                openTKPanel.Height = Convert.ToInt32(openTKPanel.Height * ZOOMFACTOR);
                openTKPanel.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //zooms out picture
        //taken from https://social.msdn.microsoft.com/Forums/windows/en-US/50ea6adc-52cf-491a-bb99-729ac83475ce/mousewheel-zoom?forum=winforms
        private void ZoomOut()
        {
            if ((openTKPanel.Width > (outerPanel.Width / MINMAX)) &&
                (openTKPanel.Height > (outerPanel.Height / MINMAX)))
            {
                openTKPanel.SizeMode = PictureBoxSizeMode.StretchImage;
                openTKPanel.Width = Convert.ToInt32(openTKPanel.Width / ZOOMFACTOR);
                openTKPanel.Height = Convert.ToInt32(openTKPanel.Height / ZOOMFACTOR);
            }
        }

        //calls the necessary method when you scroll with the mousewheel
        //taken from https://social.msdn.microsoft.com/Forums/windows/en-US/50ea6adc-52cf-491a-bb99-729ac83475ce/mousewheel-zoom?forum=winforms
        void openTKPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }

        private void disableEnableToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolPanel.Visible)
            {
                toolPanel.Visible = false;
                pan_previousX = outerPanel.Location.X;
                pan_previousY = outerPanel.Location.Y;
                pic_previousX = openTKPanel.Location.X;
                pic_previousY = openTKPanel.Location.Y;
                outerPanel.Width = outerPanel.Width + toolPanel.Width;
                openTKPanel.Width = openTKPanel.Width + toolPanel.Width;
                this.outerPanel.Location = new Point(this.toolPanel.Location.X, this.outerPanel.Location.Y);
                this.openTKPanel.Location = new Point(this.toolPanel.Location.X, this.openTKPanel.Location.Y);
            }
            else
            {

                outerPanel.Width = outerPanel.Width - toolPanel.Width;
                openTKPanel.Width = openTKPanel.Width - toolPanel.Width;
                this.outerPanel.Location = new Point(pan_previousX, pan_previousY);
                this.openTKPanel.Location = new Point(pic_previousX, pic_previousY);
                toolPanel.Visible = true;
            }
        }
    }
}

