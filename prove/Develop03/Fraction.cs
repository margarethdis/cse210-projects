

//creo la clase 

public class Fractions
{
    //creo los constructores
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;

    }

    public Fractions(int wholeNumbers)
    {
        _top = wholeNumbers;
        _bottom = 1;

    }

    public Fractions(int top , int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //creo los getters and setters

    public string GetFractionsString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return(double)_top / (double)_bottom;
    }







}