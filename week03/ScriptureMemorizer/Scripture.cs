public class Scripture
{
    // variables
    private string[] _wordsList;
    private List<string[]> _wordsListList = new List<string[]>();
    public Scripture(string scripture)
    {
        // For one verse
        _wordsList = scripture.Split(" ");
    }
    public Scripture(List<string> scriptureList)
    {
        // For multiple verses
        foreach (string verse in scriptureList)
        {
            string[] verseList = verse.Split(" ");
            _wordsListList.Add(verseList);
        }
    }
    // Getters and Setters
    public string[] GetWordsList()
    {
        return _wordsList;
    }
    public void SetWordsList(string[] wordsList)
    {
        _wordsList = wordsList;
    }
    public List<string[]> GetWordsListList()
    {
        return _wordsListList;
    }
    public void SetWordsListList(List<string[]> wordsListList)
    {
        _wordsListList = wordsListList;
    }
}