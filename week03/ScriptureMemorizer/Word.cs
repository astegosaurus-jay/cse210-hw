public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
    }


    public void Hide()
    {
        int length = _text.Length;
        foreach (int i in Enumerable.Range(1,length))
        {
            Console.Write("_");

        }

    }
    public void Show()
    {
        Console.Write(_text);

    }
    //public bool IsHidden()
    //{
        //return 
    //}
    public string GetDisplayText()
    {
        return _text;
    }
}