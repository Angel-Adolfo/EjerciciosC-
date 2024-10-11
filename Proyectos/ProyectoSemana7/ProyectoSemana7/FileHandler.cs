using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
    private readonly string filePath;

    public FileHandler(string path)
    {
        filePath = path;
    }
    public List<string> ReadJokes()
    {
        if (!File.Exists(filePath))
        {
            return new List<string>();
        }

        return new List<string>(File.ReadAllLines(filePath));
    }
    public void WriteJoke(string joke)
    {
        File.AppendAllText(filePath, joke + Environment.NewLine);
    }
}
