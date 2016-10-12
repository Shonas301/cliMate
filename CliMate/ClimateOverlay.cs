using System;

public class ClimateOverlay : Overlay
{
    private TempOverlay temp;
    private MoistureOverlay moisture;

	public ClimateOverlay()
	{
	}

    public ClimateOverlay(TempOverlay temp, MoistureOverlay moisture)
    {
        this.temp = temp;
        this.moisture = moisture;
    }

    public void calcClimates()
    {
        //TODO
    }

    public TempOverlay getTempOverlay()
    {
        return temp;
    }

    public void setTempOverlay(TempOverlay temp)
    {
        this.temp = temp;
    }

    public MoistureOverlay getMoistureOverlay()
    {
        return moisture;
    }

    public void setMoistureOverlay(MoistureOverlay moisture)
    {
        this.moisture = moisture;
    }
}
