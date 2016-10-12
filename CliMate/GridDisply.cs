using System;

public class GridDisplay
{
    public Overlay currentOverlay { get; private set; }

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
