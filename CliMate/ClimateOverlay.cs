using System;

public class ClimateOverlay : Overlay
{
    public TempOverlay temp { get; private set; }
    public MoistureOverlay moisture { get; private set; }

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
}
