using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    class Project
    {
        private String filePath;
        private int projectWidth;
        private int projectHeight;
        //The frequency (resolution) of the geodesic grid.
        private int geoFrequency;

        public Project()
        {
            //Default values for project resoultion
            this.projectWidth = 640;
            this.projectHeight = 480;
            this.geoFrequency = 4;
        }

        //ALL grids are going to need access to this. Changing these MIGHT be tricky seeing as we'd have to recalculate all the way down the node tree.
        public int getProjectWidth() { return projectWidth; }
        public int getProjectHeight() { return projectHeight; }

    }
}
