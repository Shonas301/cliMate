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
            
        }
    }
}
