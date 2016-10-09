using System;

public class Overlay
{
    private IcoVertex[] tiles;
    private int[,] keys;

	public Overlay()
	{
        tiles = new IcoVertex[100];
        keys = new int[100,100];
	}
    public Overlay(int n)
    {
        tiles = new IcoVertex[n];
        keys = new int[n, n];
    }

    public IcoVertex[] getTiles()
    {
        return tiles;
    }

    public void setTiles(IcoVertex[] tiles)
    {
        this.tiles = tiles;
    }

    public int[,] getKeys()
    {
        return keys;
    }

    public void setKeys(int[,] keys)
    {
        this.keys = keys;
    }
}

