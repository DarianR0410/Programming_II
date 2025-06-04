namespace Practica2;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		Maintenance maintenance = Maintenance.Instance();
		

		while (isRunning)
		{
			Console.WriteLine("WELCOME TO THE METHEOROLOGIC STATION MAINTENANCE.");
			Console.WriteLine("Select one of the following options:");
			Console.WriteLine("1. Clean sensor.");
			Console.WriteLine("2. Calibration.");
			Console.WriteLine("3. Sensor Replacement.");
			Console.WriteLine("4. General review.");
			Console.WriteLine("5. Exit.");
			Console.WriteLine("Enter your message:");
			string message = Console.ReadLine();

			Console.WriteLine("Select the type of message you would like to send:");
			int option = Convert.ToInt32(Console.ReadLine());

			switch (option)
			{
				case 1: maintenance.CleanSensor(message);
					break;
				case 2: maintenance.Calibration(message);
					break;
				case 3:
					maintenance.SensorReplacement(message);
					break;
				case 4:
					maintenance.GeneralReview(message);
					break;
				case 5:
					isRunning = false;
					break;
				default: Console.WriteLine("Invalid option.");
					break;
			}
		}
	}
}