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
        private int selectedNode = -1;
        private MapProject map = new MapProject();
        private Boolean midConnector = false;
        private MapNode midNode;
        private Point midConnection;

        public NodeInterface()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (selectedNode == 0)
            {
                selectedNode = -1;
            }
            else
            {
                selectedNode = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedNode == 1)
            {
                selectedNode = -1;
            }
            else
            {
                selectedNode = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedNode == 2)
            {
                selectedNode = -1;
            }
            else
            {
                selectedNode = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedNode == 3)
            {
                selectedNode = -1;
            }
            else
            {
                selectedNode = 3;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            //MessageBox.Show("" + selectedNode + " @ " + point.ToString());
            if (selectedNode == 0)
            {
                if (PointIsInNode(point).X != -1 && PointIsInNode(point).Y != -1)
                {
                    Point topLeft = PointIsInNode(point);
                    if (midConnector)
                    {
                        midConnector = false;
                        MapNode connection = map.GetNodeAtPoint(topLeft);
                        // THIS IS WHERE THE CONNECTION TAKES PLACE \/
                        connection.inputs[connection.nInputs] = midNode;
                        connection.nInputs++;
                        midNode.output = connection;
                        // THIS IS WHERE THE CONNECTION TAKES PLACE /\
                        panel1.CreateGraphics().DrawLine(new Pen(Color.FromArgb(255, 0, 0, 0)), midConnection, point);
                    }
                    else
                    {
                        midConnector = true;
                        midConnection = point;
                        midNode = map.GetNodeAtPoint(topLeft);
                    }
                }
                else
                {
                    MessageBox.Show("Error: You must select a node");
                }
            }
            if (PointIsInNode(point).X != -1 && PointIsInNode(point).Y != -1)
            {
                return;
            }
            if (selectedNode == 1)
            {
                panel1.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0)), point.X, point.Y, 20, 20);
                panel1.CreateGraphics().DrawString("1", new Font("Arial", 12), new SolidBrush(Color.Black), point.X, point.Y);
                map.AddNode(new MapNode(1, point, 20, 20));
            } else if (selectedNode == 2)
            {
                panel1.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0)), point.X, point.Y, 20, 20);
                panel1.CreateGraphics().DrawString("2", new Font("Arial", 12), new SolidBrush(Color.Black), point.X, point.Y);
                map.AddNode(new MapNode(2, point, 20, 20));
            } else if (selectedNode == 3)
            {
                panel1.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(255, 0, 0, 0)), point.X, point.Y, 20, 20);
                panel1.CreateGraphics().DrawString("3", new Font("Arial", 12), new SolidBrush(Color.Black), point.X, point.Y);
                map.AddNode(new MapNode(3, point, 20, 20));
            }
        }

        public Point PointIsInNode(Point point)
        {
            for (int i = 0; i < map.GetSize(); i++)
            {
                MapNode mn = map.GetNodeAt(i);
                try
                {
                    int x1 = mn.GetTopLeft().X;
                    int x2 = mn.GetTopLeft().X + mn.GetWidth();
                    int y1 = mn.GetTopLeft().Y;
                    int y2 = mn.GetTopLeft().Y + mn.GetHeight();
                    if ((point.X >= x1) && (point.X <= x2) && (point.Y >= y1) && (point.Y <= y2))
                    {
                        return mn.GetTopLeft();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: NULL NODES");
                }
            }
            return new Point(-1, -1);
        }
    }
}
