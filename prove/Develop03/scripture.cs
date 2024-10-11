class Scripture
{
    private string _scriptureText;
    private Reference _scriptureReference;

    public Scripture (Reference scriptureReference, string scriptureText)
    {
        _scriptureText = scriptureText;
        _scriptureReference = scriptureReference;
    }

    public string Display()
    {
        return string.Format("{0}", _scriptureText);
    }
}
