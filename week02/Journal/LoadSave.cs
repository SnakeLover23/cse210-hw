using System.Globalization;
using System.IO;

public class LoadSave
{
    public List<List<string>> Load(string fileName)
    {
        List<List<string>> entrys = new List<List<string>>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            List<string> entry = new List<string>();
            string[] parts = line.Split("|");
            entry.Add(parts[0]);
            entry.Add(parts[1]);
            entry.Add(parts[2]);
            entrys.Add(entry);
        }
        return entrys;
    }
    public void Save(string fileName, List<List<string>> entrys)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (List<string> entry in entrys)
            {
                outputFile.WriteLine($"{entry[0]}|{entry[1]}|{entry[2]}");
            }
        }
    }
}