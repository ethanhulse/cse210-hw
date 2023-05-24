public class Word
{
    public string Text {get; private set; }
    public bool isHidden {get; private set;}

    public Word(string _text)
    {
        Text = _text;
    }

    public void Hide()
    {
        isHidden = true;
    }

}