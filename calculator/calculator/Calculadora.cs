namespace calculator;

public class Calculadora
{
    private Suma suma;
    private Resta resta;
    private Multiplicacion multiplicacion;
    private Division division;

    public Calculadora()
    {
        suma = new Suma();
        resta = new Resta();
        multiplicacion = new Multiplicacion();
        division = new Division();
    }
    
    public double Sumar(double numberOne, double numberTwo)
    {
        suma.SetNumbers(numberOne, numberTwo);
        return suma.Sum();
    }

    public double Restar(double numberOne, double numberTwo)
    {
        resta.SetNumbers(numberOne, numberTwo);
        return resta.Substraction();
    }

    public double Multiplicar(double numberOne, double numberTwo)
    {
        multiplicacion.SetNumbers(numberOne, numberTwo);
        return multiplicacion.Multiplication();
    }

    public double Dividir(double numberOne, double numberTwo)
    {
        division.SetNumbers(numberOne, numberTwo);
        return division.Divide();
    }
    
}