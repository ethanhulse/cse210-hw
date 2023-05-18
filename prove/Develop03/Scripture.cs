using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


public class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;
    private Random random;


    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        text = scriptureText;
        words = new List<Word>();
        random = new Random();

        string[] splitText = text.Split(' ');

        foreach (string wordText in splitText)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }

    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{reference.ReferenceText}:");
        Console.WriteLine();

        foreach (Word word in words)
        {
            if(word.isHidden)
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        List<Word> unhiddenWords = GetUnhiddenWords();
        if(unhiddenWords.Count == 0)
        {
            return;
        }

        int randomIndex = random.Next(0, unhiddenWords.Count);
        Word randomWord = unhiddenWords[randomIndex];
        randomWord.Hide();
    }

    public List<Word> GetUnhiddenWords()
    {
        List<Word> unhiddenWords = new List<Word>();

        foreach(Word word in words)
        {
            if(!word.isHidden)
            {
                unhiddenWords.Add(word);
            }
        }
        return unhiddenWords;
    }
}

public class Reference
{

    public string ReferenceText {get; private set;}

    public Reference(string _referenceText)
    {
        ReferenceText = _referenceText;
    }

}

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



