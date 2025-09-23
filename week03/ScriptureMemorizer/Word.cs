public class Word
{
    Random rng = new Random();
    private bool _exit = false;
    int max = 0;
    int total = 0;
    public string[] BlankOutVerse(string[] wordList)
    {
        max = wordList.Length;
        for (int i = 0; i < 3; i++)
        {
            int number = rng.Next(0, wordList.Length);
            if (wordList[number] != new string('_', wordList[number].Length))
            {
                wordList[number] = new string('_', wordList[number].Length);
                total = total + 1;
            }
        }
        if (total >= max)
        {
            _exit = true;
        }
        return wordList;
    }
    public List<string[]> BlankOutVerses(List<string[]> wordListList)
    {
        max = 0;
        List<string[]> newWordListList = new List<string[]>();
        foreach (string[] wordList in wordListList)
        {
            max = max + wordList.Length;
            for (int i = 0; i < 3; i++)
            {
                int number = rng.Next(0, wordList.Length);
                if (wordList[number] != new string('_', wordList[number].Length))
                {
                    wordList[number] = new string('_', wordList[number].Length);
                    total = total + 1;
                }
            }
            
            newWordListList.Add(wordList);
        }
        if (total >= max)
        {
            _exit = true;
        }
        return newWordListList;
    }
    public bool GetExit()
    {
        return _exit;
    }
}