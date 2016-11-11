using System;
using System.Collections;
using System.IO;
using System.Linq;

[Serializable]
public class Note
{
    public int x { get; set; }
    public int y { get; set; }
    public string text;
    public ArrayList notes { get; set; }
    public string map { get; set; }
    public string mapString { get; private set; }

	public Note(string map)
	{
        this.map = map;
        this.notes = new ArrayList();
        string fullmap = map.TrimEnd(Path.DirectorySeparatorChar);
        mapString = fullmap.Split(Path.DirectorySeparatorChar).Last();
        mapString = Path.GetFileNameWithoutExtension(mapString) + ".txt";
        System.Diagnostics.Debug.Print(mapString);
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

    public Note(int x, int y,  string map)
    {
        this.x = x;
        this.y = y;
        this.map = map;
        this.notes = new ArrayList();
        string fullmap = map.TrimEnd(Path.DirectorySeparatorChar);
        mapString = fullmap.Split(Path.DirectorySeparatorChar).Last();
        mapString = Path.GetFileNameWithoutExtension(mapString) + ".txt";
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

    public Note(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public void saveNote()
    {
        if (!File.Exists(mapString))
        {
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

    public bool isNotesEmpty()
    {
        return notes.Count > 0;        
    }
}
