using System;

public class TempOverlay : Overlay
{
    private HeightOverlay height;

	public TempOverlay()
	{
	}

    public TempOverlay(HeightOverlay height)
    {
        this.height = height;
    }

    public void calcTemp()
    {
        //TODO
    }

    public HeightOverlay getHeightOverlay()
    {
        return height;
    }

    public void setHeightOverlay(HeightOverlay height)
    {
        this.height = height;
    }
}
