namespace TemperatureRecorder;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		Temperature temperature = new Temperature();
		RegisterTemperature registerTemperature = new RegisterTemperature();

		while (isRunning)
		{
			Console.WriteLine("Hello! Welcome to our temperature recorder!");
			Console.WriteLine("OPTIONS:");
			Console.WriteLine("1- Register temperature (in celsius).");
			Console.WriteLine("2- Check previous logs.");
			Console.WriteLine("3- Exit.");
			int option = Convert.ToInt32(Console.ReadLine());

			switch (option)
			{
				case 1:
					Console.WriteLine("WELCOME TO THE TEMPERATURE RECORDER");
					Console.WriteLine("To record a new temperature, please provide the following information:");
					Console.Write("temperature:");
					double temp = double.Parse(Console.ReadLine());
					temperature.TempCelcius = temp;
					Console.WriteLine("Temperature recorded!");
					registerTemperature.TemperatureTracker(temperature);
					break;
				case 2: Console.WriteLine("WELCOME TO THE TEMPERATURE RECORDER");
					Console.WriteLine("Here is the log of all temperatures");
					registerTemperature.CheckTemperatureLog();
					break;
				case 3:
					isRunning = false;
					break;
				default: Console.WriteLine("Invalid option");
					break;
			}
		}
	}
}