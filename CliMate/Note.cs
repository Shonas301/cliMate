using System;
using System.Collections;
using System.IO;

public class Note
{
    public int x { get; set; }
    public int y { get; set; }
    public ArrayList notes { get; set; }
    public string map { get; set; }

	public Note()
	{
	}

    public Note(int x, int y,  string map)
    {
        this.x = x;
        this.y = y;
        this.map = map;
        this.notes = new ArrayList();
        string mapString = map + ".txt";
        if (File.Exists(mapString))
        {
            using(StreamReader rd = File.OpenText(mapString))
            {
                string s = "";
                while ((s = rd.ReadLine()) != null)
                {
                    notes.Add(s);
                }
            }
        }
    }
    
    public void saveNote()
    {
        string mapString = map + ".txt";
        if (!File.Exists(mapString))
        {
            File.CreateText(mapString);
        }
        else
        {
            File.Delete(mapString);
        }
        using (StreamWriter sw = File.AppendText(mapString))
        {
            foreach(string x in this.notes) {
                sw.WriteLine(x);
            }
        }
    }   

    public void addNote(String s)
    {
        notes.Add(s);
    }

    public void Test()
    {
        foreach(String s in notes)
        {
            System.Diagnostics.Debug.WriteLine("Note: " + s);
        }
    }
}
