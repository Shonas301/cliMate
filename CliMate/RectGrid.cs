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
        //Yeah, you can make this whatever size you want, but this should always be projectWidth/Height
        //I just found it weird to have a project as a parameter. Project settings? Huh...
        //Maybe we should leave it as is anyway. Flexibility and all that jazz.
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