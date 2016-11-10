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
        public const double SCALE_FACTOR = 2;     //Height is divided by this magic number to keep it below 1.0

        public int seed { get { return perlinGen.Seed; } }
        public double frequency { get { return perlinGen.Frequency; } }
        public double lacunarity { get { return perlinGen.Lacunarity; } }
        public int octaveCount { get { return perlinGen.OctaveCount; } }
        public double persistence { get { return perlinGen.Persistence; } }

        private Perlin perlinGen = new Perlin();


        public PerlinNoise(int seed, int octave, double freq, double lac, double pers)
        {
            perlinGen.Seed = seed;
            perlinGen.OctaveCount = octave;

            if (freq == 0)
                perlinGen.Frequency = .1;
            else
                perlinGen.Frequency = freq;

            if (lac == 0)
                perlinGen.Lacunarity = 1.0;
            else
                perlinGen.Lacunarity = lac;

            if (pers == 0)
                perlinGen.Persistence = 1.0;
            else
                perlinGen.Persistence = pers;
        }



        public double SearchMaxValue(double searchSpace, double increment)
        {
            //Searches all positive x-values less than searchSpace.  Increments by the given value.
            //Returns the highest absolute value, not scaled by SCALE_FACTOR.
            //Very slow, only use for debugging purposes.

            double highest = double.MinValue;

            for (double x = 0; x < searchSpace; x += increment)
            {
                double val = Math.Abs(GetValue(x, 0));
                if (val > highest)
                {
                    highest = val;
                }
            }

            return highest * SCALE_FACTOR; //Un-scale it.
        }

        public double GetValue(double x, double y)
        {
            //Returns the value at the given position
            //Scales it down to make sure the absolute value is less than 1.
            return perlinGen.GetValue(x, y, 0) / SCALE_FACTOR;
        }
    }
}
