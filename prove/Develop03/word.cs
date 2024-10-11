class Word
{
    private Scripture _scripture;
    private List<String> _scriptureWords;
    private int _totalWordsRemoved = 0;

    public Word (Scripture scripture)
    {
        _scripture = scripture;
        _scriptureWords = new List<string>();
        ConvertTextList();
    }

    private void ConvertTextList()
    {
        _scriptureWords = _scripture.RefDisplay().Split(" ").ToList();
    }

    public void RemoveWords()
    {
        int numWordsRemoved = 5;
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, _scriptureWords.Count());
            if (_scriptureWords[rndIndex].Contains('_') == false);
            {
                _scriptureWords[rndIndex] = new string('_', _scriptureWords[rndIndex].Length);
                wordsRemoved++;
                _totalWordsRemoved++;
                
                if ((_scriptureWords.Count() - numWordsRemoved) <= _totalWordsRemoved && _totalWordsRemoved < (_scriptureWords.Count()+ 1))
                {
                    wordsRemoved = 3;
                }
            }
        } while (wordsRemoved != numWordsRemoved);

    }

    public string RefDisplay()
    {
        return string.Join(" ", _scriptureWords);
    }

}