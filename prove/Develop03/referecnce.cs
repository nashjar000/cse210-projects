/*
A class for a Reference should likely have 
attributes for the book, chapter, and verse, 
as well as a second "end verse" to handle the 
case of Proverbs 3:5-6. What data types would 
be appropriate for these?
*/

/*
A class for a Reference should likely have at least two different 
constructors to account for cases where there is a single verse 
or multiple verses
*/

public class Reference
{
    private string _book { get; }
    //    The { get; } is used to indicate that the property is read-only
    private int _chapter { get; }
    // reads the chapter
    private int? _verseStart { get; }
    // the int? operator is used to indicate that the verseEnd can be null
    private int? _verseEnd { get; }

    public Reference(string book, int chapter, int? verseStart = null, int? verseEnd = null)    // Constructor that accepts all three parameters
    {
        _book = book;   // Set the book
        _chapter = chapter; // Set the chapter
        _verseStart = verseStart;   // Set the verseStart
        _verseEnd = verseEnd;   // Set the verseEnd
    }
    
public override string ToString()   // Override the ToString method
{
    if (_verseStart == null && _verseEnd == null)   // Check if the verseStart and verseEnd are null
    {
        return $"{_book} {_chapter}";   // Return the book and chapter
    }
    else if (_verseStart == _verseEnd)  // Check if the verseStart and verseEnd are equal
    {
        return $"{_book} {_chapter}:{_verseStart}"; // Return the book, chapter, and verseStart
    }
    else if (_verseEnd != null) // Check if the verseEnd is not null
    {
        return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}"; // Return the book, chapter, verseStart, and verseEnd
    }
    else
    {
        return $"{_book} {_chapter}:{_verseStart}-?";   // Return the book, chapter, verseStart, and a question mark if nothing is found
    }
}
}