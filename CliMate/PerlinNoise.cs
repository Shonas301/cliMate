using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    /* Wrapper class for perlin noise */
    public class PerlinNoise
    {
        public int seed { get; private set; }

        public PerlinNoise(int seed)
        {
            this.seed = seed;
        }

        public double GetValue(double x, double y)
        {
            //Returns the value at the given position
            //TODO: Use actual perlin noise

            int xInt = x.GetHashCode();
            int yInt = y.GetHashCode();

            int combined = xInt ^ yInt ^ seed;
            double dub = (double)combined / int.MaxValue;
            dub *= 100;

            return dub;
        }
    }
}
