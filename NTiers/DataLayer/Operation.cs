namespace DataLayer;

public class Operation
{

	public Operation()
	{
		
	}
	
	public double Suma(double number1, double number2)
	{
		double result = number1 + number2;
		return result;
	}

	public double Resta(double number1, double number2)
	{ 
		double result = number1 - number2;
		return result;
	}

	public double Multiplicacion(double number1, double number2)
	{ 
		double result = number1 * number2;
		return result;
	}

	public double Division(double number1, double number2)
	{
		 double result = number1 / number2;

		if (number2 == 0)
			throw new DivideByZeroException();
		return result;
	}

}