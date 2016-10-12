using System;
using CliMate;
using System.Drawing;

public class HeightOverlay : Overlay
{
    //private PlateOverlay[] plates;    //Why do we need this?
    private bool tectonic;
    private int seaLevel;

    private Heightmap contents;

    public HeightOverlay()
	{
        tectonic = false;
        Random rand = new Random();
        seaLevel = rand.Next(1, 100); //random 
	}

    public HeightOverlay(bool tectonic, int seaLevel)
    {
        this.tectonic = tectonic;
        this.seaLevel = seaLevel;
    }

    public void tectonicSim(PlateOverlay[] plates)
    {
        //TODO
    }

    public void convertFromImage(String filepath)
    {
        //Set the heightmap
        contents = new Heightmap(new Bitmap(filepath));
    }

    public void addNoise()
    {
        //Add perlin noise to it.
    }

    public bool getTectonic()
    {
        return tectonic;
    }

    public void setTectonic(bool tectonic)
    {
        this.tectonic = tectonic;
    }

    public void getSeaLevel()
    {
        return seaLevel;
    }

    public void setSeaLevel(int seaLevel)
    {
        this.seaLevel = seaLevel;
    }

}
