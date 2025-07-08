namespace StrategyExercise;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		

		while (isRunning)
		{
			Console.WriteLine("Welcome to the Strategy Exercise!");
			Console.WriteLine("In this exercise, we are going to be exporting files. For this, please enter the following information:");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Age: ");
			int age = int.Parse(Console.ReadLine());
			Console.Write("Email: ");
			string email = Console.ReadLine();
			User user = new User();
			{
				user.Name = name;
				user.Age = age;
				user.Email = email;
			}
			Console.WriteLine("How would you like to export the information?");
			Console.WriteLine("[1] Json file [2] Csv file, [3] Txt file");
			int option = int.Parse(Console.ReadLine());

			if (option == 1)
			{
				IFileExport exportToJson = new ExportToJson();
				exportToJson.SaveToFile(user);

			} else if (option == 2)
			{
				IFileExport exportToCsv = new ExportToCsv();
				exportToCsv.SaveToFile(user);
			}
			else if (option == 3)
			{
				IFileExport exportToText = new ExportToTxt();
				exportToText.SaveToFile(user);
			}
			else
			{
				isRunning = false;
			}
		}
	}
}