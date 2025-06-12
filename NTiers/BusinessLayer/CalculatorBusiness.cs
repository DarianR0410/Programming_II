namespace BusinessLayer;
using DataLayer;

public class CalculatorBusiness
{ 
	Operation operation;
	
	public CalculatorBusiness()
	{
		operation = new Operation();
	}

	public double  Suma(double number1, double number2)
	{
		return operation.Suma(number1, number2);
	}

	public double Resta(double number1, double number2)
	{
		return operation.Resta(number1, number2);
	}

	public double Multiplicacion(double number1, double number2)
	{
		return operation.Multiplicacion(number1, number2);
	}

	public double Division(double number1, double number2)
	{
		return operation.Division(number1, number2);
	}
}