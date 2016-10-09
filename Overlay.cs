using System;

public class Overlay
{
//  IcoVertex[] tiles;
    int[,] keys;

	public Overlay()
	{
        //tiles = new IcoVertex[100];
        keys = new int[100,100];
	}
    public Overlay(int n)
    {
        //tiles = new IcoVertex[n];
        keys = new int[n, n];
    }
}
