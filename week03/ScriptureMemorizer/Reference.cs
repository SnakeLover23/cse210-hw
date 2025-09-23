public class Reference
{
    // variables
    private string _reference;
    private string _scripture;
    private List<string> _scriptureList = new List<string>();
    public Reference()
    {
        // For if your lazy
        _reference = "";
        _scripture = "";
    }
    public Reference(string reference, string scripture)
    {
        // For references with one verse
        _reference = reference;
        _scripture = scripture;
    }
    public Reference(string reference, List<string> scriptureList)
    {
        // For references with multiple verses
        _reference = reference;
        _scriptureList = scriptureList;
    }
    // Getters and Setters
    public string GetReference()
    {
        return _reference;
    }
    public void SetReference(string reference)
    {
        _reference = reference;
    }
    public string GetScripture()
    {
        return _scripture;
    }
    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }
    public List<string> GetScriptureList()
    {
        return _scriptureList;
    }
    public void SetScriptureList(List<string> scriptureList)
    {
        _scriptureList = scriptureList;
    }
}