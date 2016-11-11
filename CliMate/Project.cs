using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using CliMate;

namespace Climate
{
    [Serializable]
    public class Project
    {
        private string filePath { get; set; }
        private int projectWidth;
        private int projectHeight;
        public List<Note> notes;
        //The frequency (resolution) of the geodesic grid.
        private int geoFrequency;
        private int[,] mask;
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

        public Node GetNode(int n)
        {
            return map.GetNode(n);
        }

        public Node GetLastNode() {
            System.Diagnostics.Debug.Write(map.GetNum());
            return map.GetLastNode();
        }

        public void AddImageFileNode(string fileName) {
            ImageFileNode ifn = new ImageFileNode(map, fileName);
            map.AddNode(ifn);
        }

        public void SetFirstHeightmap(Heightmap heightmap)
        {
            //TODO: Rename this method
            //Set the input node to a new ImageFileNode using map as an input

            SetInputNode(new ImageFileNode(map, heightmap));
        }

        public void SetInputNode(InputNode node)
        {
            //Changes the input node
            map.SetFirstNode(node);
        }

        public void SaveToFile(string fileName)
        {
            BinaryFormatter saver = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileName, FileMode.Create);

            try
            {
                saver.Serialize(fileStream, this);
            }
            catch (System.Runtime.Serialization.SerializationException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

            fileStream.Close();
        }

        public void CreateMask(int x, int y)
        {
            this.mask = new int[x, y];
        }

        public int[,] GetMask()
        {
            return this.mask;
        }
        
        public void setMask(int[,] mask)
        {
            this.mask = mask;
        }

        public Boolean hasMask()
        {
            return !(mask == null);
        }

        //ALL grids are going to need access to this. Changing these MIGHT be tricky seeing as we'd have to recalculate all the way down the node tree.
        public int getProjectWidth() { return projectWidth; }
        public int getProjectHeight() { return projectHeight; }

    }
}
