/*
A class for a Scripture would likely need member 
variables for a reference and all of the words 
in the scripture. What data types would be used 
for these?
*/

/*
A class for a Scripture will need a constructor that accepts both a reference and the text of the scripture. If the Scripture class internally stores a List of Word objects, the first thought would be to pass a List<Word> variable to the constructor. While this could work, it may be easier to use the class by passing the text of the scripture as a single string with all of the words in it. Then, the constructor would have the responsibility of creating the list, and splitting up the words in the string to create Word objects for each one and put them in the list.

While putting the logic of creating the word list may seem like a lot of work for the constructor, it is helpful to encapsulate this logic in the Scripture class so that other code, does not have to worry about the internal storage of the Scripture. This would enable the program to be easily changed in the future, if a different implementation choice were made.
*/


public class Scripture
{
    public string _reference { get; }   // This is the reference
                            // the { get; } is used to indicate that the property is read-only
    public string _text { get; private set; }
                    // the { get; private set; } is used to indicate that the property is read-only. Also, it can only be set in the constructor
    public List<Word> _words { get; } // this gets the list of words
    
    
    public Scripture(string reference, string text) // Constructor that accepts both a reference and the text of the scripture
    {
        _reference = reference; // Set the reference
        _text = text;   // Set the text
        _words = SplitText(text); // Split the text into words
    }

    // encapsulation: 
    private List<Word> SplitText(string text)   // Split the text into words
    {
        // Split text into words while preserving punctuation
        List<Word> words = new List<Word>();    // Create a new list of words

        int startIndex = 0; // Start index of the current word
        bool inWord = false;    // Flag to indicate if we are currently in a word

        for (int i = 0; i < text.Length; i++) // Loop through the text
        {
            if (char.IsLetterOrDigit(text[i]))  // Check if the character is a letter or number
            {
                inWord = true;  // Set the flag to indicate we are in a word
            }

            else if (inWord)    // Check if we are in a word
            {
                words.Add(new Word(text.Substring(startIndex, i - startIndex))); // Add the word to the list
                startIndex = i + 1; // Set the start index of the next word
                inWord = false; // Set the flag to indicate we are not in a word
            }
        }

        if (inWord) // Check if we are in a word
        {
            words.Add(new Word(text.Substring(startIndex)));    // Add the last word to the list
        }
        return words;   // Return the list of words
    }
public void HideRandomWord()    // Hide a random word
{
    // Shuffle the list of words
    var shuffledWords = _words.OrderBy(a => Guid.NewGuid()).ToList();   // Randomize the order of the words

    // Find the first word that is not hidden and hide it
    var hiddenWord = shuffledWords.FirstOrDefault(word => !word._isHidden); // Find the first word that is not hidden
    
    if (hiddenWord != null) // Check if a word was found
    {
        hiddenWord.Hide();  // Hide the word
    }

    // Update text with hidden words
    _text = string.Join(" ", _words.Select(word => word.ToString()));   // Update the text with the hidden words
}
}