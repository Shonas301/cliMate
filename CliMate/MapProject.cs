using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliMate
{
    class MapProject
    {
        //private MapNode[] nodes;
        private ArrayList nodes;

        public MapProject()
        {
            nodes = new ArrayList();
            nodes.Capacity = 1;
        }

        public int GetSize()
        {
            return nodes.Capacity - 1;
        }

        public void AddNode(MapNode node)
        {
            nodes.Add(node);
            nodes.Capacity++;
        }

        public void RemoveNode(int index)
        {
            nodes.RemoveAt(index);
            nodes.Capacity--;
        }

        public MapNode GetNodeAt(int index)
        {
            try
            {
                return (MapNode)nodes[index];
            } catch (Exception e)
            {
                MessageBox.Show("" + index + " " + nodes.Capacity);
                return null;
            }
        }

        public MapNode GetNodeAtPoint(System.Drawing.Point point)
        {
            for (int i = 0; i < this.GetSize(); i++)
            {
                MapNode mn = this.GetNodeAt(i);
                try
                {
                    int x1 = mn.GetTopLeft().X;
                    int x2 = mn.GetTopLeft().X + mn.GetWidth();
                    int y1 = mn.GetTopLeft().Y;
                    int y2 = mn.GetTopLeft().Y + mn.GetHeight();
                    if ((point.X >= x1) && (point.X <= x2) && (point.Y >= y1) && (point.Y <= y2))
                    {
                        return mn;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: NULL NODES");
                }
            }
            return new MapNode(-1, new System.Drawing.Point(-1, -1), -1, -1);
        }
    }
}
