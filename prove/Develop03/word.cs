/*
A class for a Word will need attributes as well. 
What should they look like?
*/

/*
Words:
    And if men come unto me I will show unto them their 
    weakness. I give unto men weakness that they may be humble; 
    and my grace is sufficient for all men that humble themselves 
    before me; for if they humble themselves before me, and have 
    faith in me, then will I make weak things become strong unto them.
*/

/*
A class for a Word will a constructor as well. This constructor should 
likely accept the text of the word to save it as an attribute. In addition, 
the constructor will need to set the initial visibility of the word 
(whether it is shown or hidden). Is this something that the user should 
pass in directly, or can the constructor just assign a value?
*/

public class Word
{
    private string _value { get; }  
    //    The { get; } is used to indicate that the property is read-only 
    public bool _isHidden { get; private set; } 
    // the private set; is used to indicate that the property is read-only

    public Word(string value)   // Constructor that accepts the text of the word
    {
        _value = value;     // Set the value of the word
        _isHidden = false;  // Set the initial visibility of the word
    }

    public void Hide()
    {
        _isHidden = true;   // check to see if word is hidden
    }

    // Other idea for this function: I can find the length of the word and replace it with one _
    public override string ToString()
    {
        return _isHidden ? "_____" : _value;    // replaces words that aren't hidden with the words with _____
    }
}