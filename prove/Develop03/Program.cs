using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {

        Scripture myScripture = new Scripture("D&C 6:36", "Look unto me in every thought; doubt not, fear not.");

        myScripture.DisplayScripture();


        while(true)
        {
            Console.WriteLine("Press 'Enter' to continue or type 'quit' to exit.");

            string input = Console.ReadLine();
            if(input == "quit")
            {
                break;
            }

            myScripture.HideRandomWord();
            myScripture.DisplayScripture();

            if (myScripture.GetUnhiddenWords().Count == 0)
            {
                break;
            }
        }
    }
}















/*

3 Class objects

Scripture Parent
    Reference Child/Parent
        Word Child



Constructors Scripture

Scripture(Reference)
Scripture(Reference, Reference_Text)

//Setters/Getters

string GetReference();
string GetReference_Text();
new scripture(John 1 1-4, "verse1", "verse2"...) 




*/