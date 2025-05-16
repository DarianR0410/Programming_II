namespace calculator;

public class Suma
{
    private double numberOne { get; set; }
    private double numberTwo { get; set; }

    public double Sum()
    {
        double result = numberOne + numberTwo;
        return result;
    }

    public void SetNumbers(double numberOne, double numberTwo)
    {
        this.numberOne = numberOne;
        this.numberTwo = numberTwo;
    }
    
}