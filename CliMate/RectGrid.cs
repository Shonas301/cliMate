using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    class RectGrid
    {
        Tile[][] grid;
        public RectGrid(int xres, int yres)
        {
            for (int i = 0; i < yres; i++)
            {
                grid[i] = new Tile[xres];
                for (int j = 0; j<xres; j++)
                {
                    grid[i][j] = new Tile(System.Drawing.Color.Black);
                }
            }
        }

    }
}
