namespace calculator;

public class Division
{
    private double numberOne { get; set;  }
    private double numberTwo { get; set; }

    public double Divide()
    {
        double result = numberOne / numberTwo;

        if (numberTwo == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero. ERROR!");
        } else {
            return result;
        }
        
    }

    public void SetNumbers(double numberOne, double numberTwo)
    {
        this.numberOne = numberOne;
        this.numberTwo = numberTwo;
    }
}