using System;

public class IcoVertex
{
    private int value;
    private bool edge;
    private bool corner;

	public IcoVertex()
	{
        this.value = 0;
        this.edge = false;
        this.corner = false;
	}

    public IcoVertex(int value, bool edge, bool corner)
    {
        this.value = value;
        this.edge = edge;
        this.corner = corner;
    }

    public int getValue()
    {
        return value;
    }

    public void setValue(int value)
    {
        this.value = value;
    }

    public bool getEdge()
    {
        return edge;
    }

    public void setEdge(bool edge)
    {
        this.edge = edge;
    }

    public bool getCorner()
    {
        return this.corner;
    }

    public void setCorner(bool corner)
    {
        this.corner = corner;
    }
}
