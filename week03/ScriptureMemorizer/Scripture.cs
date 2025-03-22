public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string scripture = text;
        string[] parts = scripture.Split(" ");
        foreach (string i in parts)
        {
            //_words.Add(i);
        }
        

        
    }

    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }

    //public bool IsCompletelyHidden()

}