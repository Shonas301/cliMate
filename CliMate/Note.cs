using System;

public class Note
{
    public int x { get; set; }
    public int y { get; set; }
    public string note { get; set; }
    public string map { get; set; }

	public Note()
	{
	}

    public Note(int x, int y, string note, string map)
    {
        this.x = x;
        this.y = y;
        this.note = note;
        this.map = map;
    }
    
    public void SaveNote()
    {

    }   
}
