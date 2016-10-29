using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    class RectGrid
    {
        public const double MAX_HEIGHT = 100;   //Goes both positive and negative.  TODO: Enforce this limit somehow.

        Tile[][] grid;
        //Yeah, you can make this whatever size you want, but this should always be projectWidth/Height
        //I just found it weird to have a project as a parameter. Project settings? Huh...
        //Maybe we should leave it as is anyway. Flexibility and all that jazz.
        public RectGrid(int xres, int yres)
        {
            for (int i = 0; i < yres; i++)
            {
                grid[i] = new Tile[xres];
                for (int j = 0; j < xres; j++)
                {
                    grid[i][j] = new Tile(System.Drawing.Color.Black);
                }
            }
        }
        public Tile GetValue(int x, int y)
        {
            return grid[x][y];
        }

        public void SetColor(int x, int y, Color value)
        {
            grid[x][y].setColor(value);
        }

        //TODO integrate toBitmap
        /*
        public Bitmap ToBitmap()
        {
            //Returns a bitmap of this heightmap

            Bitmap bitmap = new Bitmap(width, height);

            //Convert every height to a color and save it on the bitmap.
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double value = GetValue(x, y);
                    bitmap.SetPixel(x, y, ValueToColor(value));
                }
            }

            //Return the bitmap
            return bitmap;
        }
        */

        public static Color ValueToColor(double value)
        {
            //Converts the given height value to a color

            double minHeight = MAX_HEIGHT * -1;

            //Shift value and max height to simulate minHeight being zero.
            double shiftedVal = value - minHeight;
            double shiftedMax = MAX_HEIGHT - minHeight;

            //Find what percentage of shiftedMax shiftedVal is.
            double percent = shiftedVal / shiftedMax;

            //Use the computed percent value to lerp between black and white
            return Utils.LerpColor(Color.White, Color.Black, percent);
        }

        public static double ColorToValue(Color color)
        {
            //Returns the value that the given color represents
            //This is slightly lossy, because we're storing it as a decimal but saving it as an integer.
            //Then we're loading it as an integer and turning it into a decimal.

            return color.GetBrightness() * MAX_HEIGHT;

        }
    }
}