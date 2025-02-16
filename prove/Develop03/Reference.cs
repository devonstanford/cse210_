public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string referenceText)
    {
        string[] bookOut = referenceText.Split(' ');
        _book = bookOut[0];
        string[] chapterOut = bookOut[1].Split(':');
        _chapter = int.Parse(chapterOut[0]);
        string[] verseOut = chapterOut[1].Split('-');
        _startVerse = int.Parse(verseOut[0]);
        if (verseOut.Length > 1)
        {
            _endVerse = int.Parse(verseOut[1]);
        }
    }

    public string GetDisplayContent()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}