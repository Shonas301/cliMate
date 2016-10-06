using System;

public class Project
{

    private String filePath;
    private int frequency; //unclear about what this does
    //private Overlay[] mapData;

    public Project()
    {
        this.filePath = Path.GetFullPath(@"mydir");
        this.frequency = 10; //random value?
        //this.mapData = new Overlay[x]; 
    }

    public Project(String filePath, int frequency)
    {
        this.filePath = filePath;
        this.frequency = frequency;
        //this.mapData = new Overlay[x];
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

    /*
    public void getOverlays()
    {
        return mapData;
    }
    */
    public void save() {}

    public void load() {}
}
