using BusinessLayer;

namespace PresentationLayer;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		CalculatorBusiness calculator = new CalculatorBusiness();

		while (isRunning)
		{
			int option;
			double number1;
			double number2;
			double result;

			Console.WriteLine("WELCOME TO THE CALCULATOR!");
			Console.WriteLine("What would you like to do today?");
			Console.WriteLine("[1] Addition [2] Substraction [3] Multiplication [4] Division [5] EXIT");
			option = Convert.ToInt32(Console.ReadLine());

			switch (option)
			{
				case 1:
					Console.WriteLine("Hi! To make the following operation, please provide two numbers");
					Console.Write("Enter first number: ");
					number1 = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter second number: ");
					number2 = Convert.ToDouble(Console.ReadLine());
					result = calculator.Suma(number1, number2);
					Console.WriteLine("The result is: " + result);
					break;
				case 2:
					Console.WriteLine("Hi! To make the following operation, please provide two numbers");
					Console.Write("Enter first number: ");
					number1 = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter second number: ");
					number2 = Convert.ToDouble(Console.ReadLine());
					result = calculator.Resta(number1, number2);
					Console.WriteLine("The result is: " + result);
					break;
				case 3:
					Console.WriteLine("Hi! To make the following operation, please provide two numbers");
					Console.Write("Enter first number: ");
					number1 = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter second number: ");
					number2 = Convert.ToDouble(Console.ReadLine());
					result = calculator.Multiplicacion(number1, number2);
					Console.WriteLine("The result is: " + result);
					break;
				case 4:
					Console.WriteLine("Hi! To make the following operation, please provide two numbers");
					Console.Write("Enter first number: ");
					number1 = Convert.ToDouble(Console.ReadLine());
					Console.Write("Enter second number: ");
					number2 = Convert.ToDouble(Console.ReadLine());
					result = calculator.Division(number1, number2);
					Console.WriteLine("The result is: " + result);
					break;
				case 5: isRunning = false;
					break;
				default: Console.WriteLine("Invalid option");
					break;
			}
		}
	}
}