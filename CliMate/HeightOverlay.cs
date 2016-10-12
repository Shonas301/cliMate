using System;

public class HeightOverlay : Overlay
{
    public PlateOverlay[] plates { get; private set; }
    public bool tectonic { get; private set; }
    public int seaLevel { get; private set; }
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

    

    

}
