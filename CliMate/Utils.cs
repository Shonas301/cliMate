using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CliMate
{
    public static class Utils
    {
        public static double Lerp(double a, double b, double t)
        {
            //Returns the linear interpolation(tween) between a and b at time t
            //t is meant to be between 0 and 1 inclusive

            double diff = b - a;
            return a + diff * t;
        }

        public static Color LerpColor(Color a, Color b, double t)
        {
            //Returns the linear interpolation(tween) between a and b at time t.
            //t is meant be between 0 and 1 inclusive

            double alpha = Lerp((double)a.A, (double)b.A, t);
            double red = Lerp((double)a.R, (double)b.R, t);
            double green = Lerp((double)a.G, (double)b.G, t);
            double blue = Lerp((double)a.B, (double)b.B, t);

            return Color.FromArgb((int)alpha, (int)red, (int)green, (int)blue);
        }

        public static int CapBounds(int num, int min, int max)
        {
            //Ensures num is inside the given inclusive bounds

            if (num < min)
            {
                num = min;
            }

            if (num > max)
            {
                num = max;
            }

            return num;
        }
    }
}
