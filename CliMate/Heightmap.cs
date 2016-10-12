using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CliMate
{
    public class Heightmap
    {
        public const double MAX_HEIGHT = 100;   //Goes both positive and negative.  TODO: Enforce this limit somehow.

        public int width { get; private set; }
        public int height{ get; private set; }

        private double[,] contents;

        public Heightmap(int width, int height)
        {
            this.width = width;
            this.height = height;

            contents = new double[width, height];
        }

        public Heightmap(Bitmap bitmap) : this(bitmap.Width, bitmap.Height)
        {
            //Imports a heightmap from a bitmap

            //Convert every pixel to a height
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    SetValue(x, y, ColorToValue(c));
                }
            }

        }

        public double GetValue(int x, int y)
        {
            return contents[x, y];
        }

        public void SetValue(int x, int y, double value)
        {
            contents[x, y] = value;
        }

        public Bitmap ToBitmap()
        {
            //Returns a bitmap of this heightmap

            Bitmap bitmap = new Bitmap(width, height);

            //Convert every height to a color and save it on the bitmap.
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bitmap.SetPixel(x, y, ValueToColor(GetValue(x, y)));
                }
            }

            //Return the bitmap
            return bitmap;
        }

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

            return color.GetBrightness();
        }
    }
}
