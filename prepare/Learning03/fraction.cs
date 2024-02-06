public class Fraction
{
    // Private member variables:
    private int _top;
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
        return text;
    }

    // Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}