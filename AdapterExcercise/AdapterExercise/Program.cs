namespace AdapterExcercise;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to our temperature register!");
		Console.WriteLine("[1] Check the temperature [2] Check temperature and pressure");
		int option = Int32.Parse(Console.ReadLine());
		if (option == 1)
		{
			Console.Write("Enter today's temperature:");
			string temperature = Console.ReadLine();
			TempSensor tempSensor = new TempSensor();
			tempSensor.MeteorologicalMessage(temperature);
			Console.WriteLine(tempSensor.MeteorologicalMessage(temperature));
		} else if (option == 2)
		{
			Console.Write("Enter pressure:");
			decimal pressure = Convert.ToDecimal(Console.ReadLine());
			SensorAdapter tempAndPressure = new SensorAdapter();
			tempAndPressure.Pressure = pressure;
			Console.Write("Enter temperature:");
			string todayTemp = Console.ReadLine();
			tempAndPressure.MeteorologicalMessage(todayTemp);
			Console.WriteLine(tempAndPressure.MeteorologicalMessage(todayTemp));
		}
	}
}