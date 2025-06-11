namespace SurveyProject;

public class SurveyManager
{
	private string path = "C:\\Users\\Darian Ramos\\C#\\SurveyProject\\Tracker\\Survey.txt";
	List<Customer> customers;

	private SurveyManager()
	{
		customers = new List<Customer>();
	}

	private static SurveyManager _instance;

	public static SurveyManager GetInstance()
	{
		if (_instance == null)
			_instance = new SurveyManager();
		return _instance;
	}

	public void Rating(string message, Customer customer)
	{
		TextWriter rating = new StreamWriter(path, true);
		rating.WriteLine("**********************************");
		rating.WriteLine("Date: " + DateTime.Now);
		rating.WriteLine("Customer: " + customer.Name);
		rating.WriteLine("ID/SSN: " + customer.Id);
		rating.WriteLine("Score: " + customer.Score);
		rating.WriteLine("Message: " + message);
		rating.WriteLine("**********************************");
		rating.Close();

		if (customer.Name != null && customer.Score != null && customer.Id > 0)
			customers.Add(customer);
		else
			throw new ArgumentException("Please enter valid information to proceed with the survey.");
	}

	public void CheckRatingLog()
	{
		TextReader reader = new StreamReader(path);
		Console.Write(reader.ReadToEnd());
		reader.Close();
	}
}