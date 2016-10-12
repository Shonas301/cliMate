using System;

public class HeightOverlay : Overlay
{
    private PlateOverlay[] plates;
    private bool tectonic;
    private int seaLevel;
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

    public void tectonicSim()
    {
        //TODO
    }

    public void convertFromImage(String filepath)
    {
        //TODO
        //All in Alex's code, conspire to rework his into this class?
    }

    public void addNoise()
    {
        //TODO
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
