using System;
using System.IO;

public class Project
{

    private String filePath;
    private int frequency; //unclear about what this does
    private Overlay[] mapData;

    //Built-in overlays
    public HeightOverlay heightOverlay { get; private set; }
    public MoistureOverlay moistureOverlay { get; private set; }
    public TempOverlay tempOverlay { get; private set; }

    /*
    public Project()
    {
        this.filePath = Path.GetFullPath(@"mydir");
        this.frequency = 10; //random value?
        this.mapData = new Overlay[10];  
    }*/

    public Project(String filePath = null, int frequency = 10)
    {
        //Frequency is defaulted to a random value.
        //Default filePath to Path.GetFullPath
        if (filePath == null)
        {
            filePath = Path.GetFullPath(@"mydir");
        }

        this.filePath = filePath;
        this.frequency = frequency;
        this.mapData = new Overlay[10]; //chosen randomly, needs to be re chosen

        //Initialize the built-in overlays
        heightOverlay = new HeightOverlay();
        moistureOverlay = new MoistureOverlay();
        tempOverlay = new TempOverlay();

        //Add all built-in overlays
        addOverlay(heightOverlay);
        addOverlay(moistureOverlay);
        addOverlay(tempOverlay);
    }

    public String getFilePath()
    {
        return this.filePath;
    }

    public void setFilePath(String filePath)
    {
        this.filePath = filePath;
    }

    public int getFrequency()
    {
        return this.frequency;
    }

    public void setFrequency(int frequency)
    {
        this.frequency = frequency;
    }

    
    public Overlay[] getOverlays()
    {
        return mapData;
    }

    public void addOverlay(Overlay overlay)
    {
        //TODO
    }
    
    public void save() {}

    public void load() {}
}
