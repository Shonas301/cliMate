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
    }
}
