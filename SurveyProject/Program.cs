namespace SurveyProject;

class Program
{
	static void Main(string[] args)
	{
		Customer customer = new Customer();
		SurveyManager surveyManager = SurveyManager.GetInstance();
		bool isRunning = true;

		while (isRunning)
		{
			Console.WriteLine("WELCOME TO THE SURVEY!");
			Console.WriteLine("Options:");
			Console.WriteLine("1- Take the survey.");
			Console.WriteLine("2- check all surveys.");
			Console.WriteLine("3- Exit");
			int option = Convert.ToInt32(Console.ReadLine());

			switch (option)
			{
				case 1:
					Console.WriteLine("WELCOME TO OUR SURVEY SYSTEM");
					Console.WriteLine("To give us a survey please help us with providing the following information: ");
					Console.Write("Please provide your full name: ");
					string name = Console.ReadLine();
					customer.Name = name;
					Console.Write("Please provide your ID/SSN: ");
					long id = long.Parse(Console.ReadLine());
					customer.Id = id;
					Console.Write("Please provide your score (from 1 to 5): ");
					int score = Convert.ToInt32(Console.ReadLine());
					customer.Score = score;
					Console.Write("would you like to add a message? (y/n): ");
					char answer = Console.ReadKey().KeyChar;
					if (answer == 'y')
					{
						Console.WriteLine("Please add your message: ");
						string message = Console.ReadLine();
						surveyManager.Rating(message, customer);
					}
					else if (answer == 'n')
					{
						string message = "N/A";
						surveyManager.Rating(message, customer);
					}
					break;
				case 2: 
					Console.WriteLine("Here is the list of all of the surveys");
					surveyManager.CheckRatingLog();
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