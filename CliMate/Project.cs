using System;
using System.IO;

using System.Collections.Generic;
using CliMate;

namespace Climate
{
    public class Project
    {
        private string filePath { get; set; }
        private int projectWidth;
        private int projectHeight;
        //The frequency (resolution) of the geodesic grid.
        private int geoFrequency;
        private NodeMap map { get; set; }

        public Project()
        {
            //Default values for project resoultion
            this.projectWidth = 640;
            this.projectHeight = 480;
            this.geoFrequency = 4;
            map = new NodeMap();
        }

        public Project(int width, int height, int frequency)
        {
            this.projectWidth = width;
            this.projectHeight = height;
            this.geoFrequency = frequency;
            map = new NodeMap();
        }

        public void AddNode(Node n) {
            map.AddNode(n);
        }

        public Node GetInputNode(Node n)
        {
            return map.GetNode(0);
        }

        public Node GetLastNode() {
            return map.GetLastNode();
        }

        public void AddImageFileNode(string fileName) {
            ImageFileNode ifn = new ImageFileNode(map, fileName);
            map.AddNode(ifn);
        }


        //ALL grids are going to need access to this. Changing these MIGHT be tricky seeing as we'd have to recalculate all the way down the node tree.
        public int getProjectWidth() { return projectWidth; }
        public int getProjectHeight() { return projectHeight; }

    }
}
