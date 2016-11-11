using Climate;
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


        //records the previous location for the picturebox
        int pic_previousX;
        int pic_previousY;

        //records the previous location for the panel
        int pan_previousX;
        int pan_previousY;

        //original width and height of the picturebox
        int orW;
        int orH;

        //width and height for the picture when toolbar is disabled
        int disW;
        int disH;

        private double ZOOMFACTOR = 1.25; 
        private int MINMAX = 3;

        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            orW = openTKPanel.Width;
            orH = openTKPanel.Height;
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

                //TODO
                currentOpenProject.AddImageFileNode(fileName);
                //currentOpenProject.heightOverlay.convertFromImage(fileName);
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
                //currentOpenProject.FileName = fileName;
                //currentOpenProject.heightOverlay.convertFromImage(fileName);
                //System.Diagnostics.Debug.Write("\r\n" + fileName + "\r\n we did it \r\n");
                UpdateDisplay();
            }
        }
        private void UpdateDisplay()
        {
            //Get the image of the map
            Image img = currentOpenProject.GetLastNode().ToBitmap();

            //Draw latitude lines
            Graphics g = Graphics.FromImage(img);
            Pen pen = new Pen(Color.Red);

            int numLines = 24;
            for (int i = 0; i < numLines; i++)
            {
                //Calculate the height to draw this line at
                double y = i * (img.Height / numLines);

                //Draw the line
                Point p1 = new Point(0, (int)y);
                Point p2 = new Point(img.Width, (int)y);

                g.DrawLine(pen, p1, p2);
            }

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


            //TODO get new project parameters, how they want to generate, etc
            //override "currentOpenProject" with the new parameters (if they want them)
            

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
            /*if(currentOpenProject.notes == null)
            {
                MessageBox.Show("Sorry no project loaded yet!", "Error");
                return;
            }
            NoteForm nF = new NoteForm(currentOpenProject.notes);
            nF.ShowDialog();
            */
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open dialog with new project parameters
            //override "Current open project"
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
        void outerPanel_MouseWheel(object sender, MouseEventArgs e)
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
            if (toolPanel.Visible & openTKPanel.Width == orW & openTKPanel.Height == orH)
            {
                //makes toolbar invisible
                toolPanel.Visible = false;

                //records original locations
                pan_previousX = outerPanel.Location.X;
                pan_previousY = outerPanel.Location.Y;
                pic_previousX = openTKPanel.Location.X;
                pic_previousY = openTKPanel.Location.Y;
                
                //changes sizes of the picturebox and panel
                outerPanel.Width = outerPanel.Width + toolPanel.Width;
                openTKPanel.Width = openTKPanel.Width + toolPanel.Width;
                this.outerPanel.Location = new Point(this.toolPanel.Location.X, this.outerPanel.Location.Y);
                this.openTKPanel.Location = new Point(this.toolPanel.Location.X, this.openTKPanel.Location.Y);
               
                //records the height and width of the new picturebox
                disW = openTKPanel.Width;
                disH = openTKPanel.Height;
            }
            //checks to see the zoom is 0
            else if (toolPanel.Visible == false & openTKPanel.Width == disW & openTKPanel.Height == disH)
            {
                //resizes the picturebox and panel to its original size
                outerPanel.Width = outerPanel.Width - toolPanel.Width;
                openTKPanel.Width = openTKPanel.Width - toolPanel.Width;

                //sets it back to the original location
                this.outerPanel.Location = new Point(pan_previousX, pan_previousY);
                this.openTKPanel.Location = new Point(pic_previousX, pic_previousY);

                //makes toolbar visible again
                toolPanel.Visible = true;
            }
        }
    }
}

