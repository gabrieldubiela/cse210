using System;

public class Fraction (int 1, int 1)
{
  private int _top = 1;
  private int _bottom = 1;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }
  
  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }
  
  public string GetFractionString()
  {
    Console.WriteLine($"{top}/{bottom}");
  }

  public double GetDecimalValue()
    {
      return (double)_top / (double)_bottom;
    }
}
