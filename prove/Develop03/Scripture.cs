public class Scripture
{
    private List<Word> _words;
    private Reference _ref;

    public Scripture(Reference reference, string content)
    {
        _ref = reference;
        _words = new List<Word>();
        string[] words = content.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public Reference GetReference()
    {
        return _ref;
    }

    public void HideRandomWords(int num)
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }

        if (count < num)
        {
            num = count;
        }
        
        for (int i = 0; i < num;)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                i++;
            }
            
        }
    }

    public void Display()
    {
        foreach (Word word in _words)
        {
            Console.Write(" "+word.Get());
        }
        Console.WriteLine();
    }
}