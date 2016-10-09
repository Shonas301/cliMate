using System;

public class PlateOverlay : Overlay
{
    private int weight;
    private int[] movement;

	public PlateOverlay() : base()
	{
        Random rand = new Random();

        this.weight = rand.Next(1, 100);
        this.movement = new int[2];
	}

    public PlateOverlay(int weight, int[] movement)
    {
        this.weight = weight;
        this.movement = movement; //add bound checking 
    }

    public int getWeight()
    {
        return this.weight;
    }

    public void setWeight(int weight)
    {
        this.weight = weight;
    }

    public int[] getMovement()
    {
        return this.movement;
    }

    public void setMovement(int[] movement)
    {
        this.movement = movement;
    }
    private void move()
    {

    }
}
