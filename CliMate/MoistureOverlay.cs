using System;

public class MoistureOverlay : Overlay
{
    //private HeightMap height
    private HeightOverlay height;

	public MoistureOverlay()
	{
	}

    public MoistureOverlay(HeightOverlay height)
    {
        this.height = height;
    }

    public void calcMoisture()
    {
        //TODO
    }

    private HeightOverlay getHeight()
    {
        return height;
    }

    private void setHeight(HeightOverlay height)
    {
        this.height = height;
    }
}
