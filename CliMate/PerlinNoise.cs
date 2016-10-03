using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpNoise.Modules;

namespace CliMate
{
    /* Wrapper class for perlin noise */
    public class PerlinNoise
    {
        public int seed { get { return perlinGen.Seed; } }

        private Perlin perlinGen = new Perlin();

        public PerlinNoise(int seed)
        {
            perlinGen.Seed = seed;
            perlinGen.Frequency = 0.5;
        }

        public double GetValue(double x, double y)
        {
            //Returns the value at the given position
            return perlinGen.GetValue(x, y, 0);
        }
    }
}
