using System;

public class IcoVertex
{
    public int value { get; private set; }
    public bool edge { get; private set; }
    public bool corner { get; private set; }

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
}
