public class Word
{
    private string _content;
    private bool _isHidden;

    public Word(string content)
    {
        _content = content;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string Get()
    {
        if (_isHidden)
        {
            string content = "";
            foreach (char letter in _content)
            {
                if (char.IsLetter(letter))
                {
                    content += "_";
                }
                else
                {
                    content += letter;
                }
            }
            return content;
        }
        else
        {
            return _content;
        }
    }
}