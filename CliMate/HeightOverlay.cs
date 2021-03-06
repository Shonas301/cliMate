﻿using System;
using CliMate;
using System.Drawing;

public class HeightOverlay //: Overlay
{
    //private PlateOverlay[] plates;    //Why do we need this?
    private bool tectonic;
    private int seaLevel;

    public Heightmap contents = new Heightmap(1, 1);

    /*
    public HeightOverlay()
	{
        tectonic = false;
        Random rand = new Random();
        seaLevel = rand.Next(1, 100); //random 
	}
    */

    public HeightOverlay(bool tectonic = false, int seaLevel = 0)
    {
        this.tectonic = tectonic;
        this.seaLevel = seaLevel;

        /*
        Random rand = new Random();
        seaLevel = rand.Next(1, 100); //random
        //Removed this part because I think it should be initialized to something deterministic, like zero.
        //If you want a random sea level, pass a random number as a parameter.
        */
    }

    /*public void tectonicSim(PlateOverlay[] plates)
    {
        //TODO
    }*/

    public void convertFromImage(String filepath)
    {
        //Set the heightmap
        contents = new Heightmap(new Bitmap(filepath));
    }

    public Bitmap ToBitmap()
    {
        return contents.ToBitmap();
    }

    public void addNoise(PerlinNoise perlinGen)
    {
        //Adds noise from the given PerlinNoise generator to every pixel in the heightmap.

        //Assertion: contents must not be null
        if (contents == null)
        {
            throw new Exception("HeightOverlay.contents is null.");
        }

        //Iterate over all pixels
        for (int x = 0; x < contents.width; x++)
        {
            for(int y = 0; y < contents.height; y++)
            {
                //Add the corresponding noise value to this pixel
                double currentVal = contents.GetValue(x, y);
                double noiseVal = perlinGen.GetValue((double)x, (double)y);

                contents.SetValue(x, y, currentVal + noiseVal);
            }
        }
    }

    public bool getTectonic()
    {
        return tectonic;
    }

    public void setTectonic(bool tectonic)
    {
        this.tectonic = tectonic;
    }

    public int getSeaLevel()
    {
        return seaLevel;
    }

    public void setSeaLevel(int seaLevel)
    {
        this.seaLevel = seaLevel;
    }

}
