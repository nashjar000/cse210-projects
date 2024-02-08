public class Fraction
{
    // Private member variables:
    private int _top;   //ints cannot store a decimal :)
    private int _bottom;

    
    public Fraction()
    {
        _top = 1;   // numerator
        _bottom = 1; // denominator
    }

    // Whole number function
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber; // numerator (whole number...this will be put in the main program)
        _bottom = 1;        // denominator
    }

    public Fraction(int top, int bottom)
    {
        _top = top; // numerator
        _bottom = bottom; // denominator
    }

    // Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        /*
        Another way to do it:

        string text = _top + "/" + _bottom;

        I personally will probably use what I did--it's 
        similar to what I'm learning in my JS class 
        right now, so, it's more familiar to me.
        */ 
        return text;
    }

    // Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom; // This function is doing math. I can also use floats--yum, root beer floats!--instead of doubles if I wanted to. However, floats store less than doubles, so, doubles might be better for this function.
    }
}