using System;

public class GridDisplay
{
    private Overlay currentOverlay;

	public GridDisplay()
	{
        //Idk what to initialize here
	}

    public void updateOverlay(Overlay next)
    {
        this.currentOverlay = next;
    }

    public void display()
    {
        //no clue
    }

    public void setTitle(int x, int y, int v)
    {
        //something like currentOverlay.getTiles()[x][y] = v;
    }
}
