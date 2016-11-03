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
    public partial class NodeInterface : Form
    {
        public int selectedNode = 0;
        public NodeInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedNode = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedNode = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedNode = 3;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            MessageBox.Show("" + selectedNode + " @ " + point.ToString());
        }
    }
}
