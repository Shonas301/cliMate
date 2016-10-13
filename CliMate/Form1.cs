using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                currentOpenProject.heightOverlay.convertFromImage(fileName);
                //System.Diagnostics.Debug.Write("\r\n this line ran: currentOpenProject.heightOverlay.convertFromImage(fileName); \rn");
            }
        }      

        private void openRecentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string recent = @"remberence.txt";
            if(!File.Exists(recent))
            {
                MessageBox.Show("No recent files to open!");
            }
            else
            {
                string fileName;
                System.IO.StreamReader file = new System.IO.StreamReader(recent);
                fileName = file.ReadLine();
                currentOpenProject.heightOverlay.convertFromImage(fileName);
                //System.Diagnostics.Debug.Write("\r\n" + fileName + "\r\n we did it \r\n");
            }
        }
        private void UpdateDisplay()
        {
            openTKPanel.BackgroundImage = currentOpenProject.heightOverlay.ToBitmap();

        }
    }

