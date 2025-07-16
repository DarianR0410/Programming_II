namespace PracticaFactory;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		

		while (isRunning)
		{
			Console.WriteLine("Currency convertor");
			Console.Write("Enter the amount you would like to convert: ");
			decimal amount = decimal.Parse(Console.ReadLine());
			DominicanPeso peso = new DominicanPeso();
			peso.Money = amount;
			Console.WriteLine("To what you would like to convert:");
			string appliedConversion = Console.ReadLine();
			Console.WriteLine("Alright, since you would like to convert to " + appliedConversion + " please select the correspondent option:");
			Console.WriteLine("1. Convert Euro");
			Console.WriteLine("2. Convert Dollar");
			Console.WriteLine("3. Convert Colombian peso");
			int option = int.Parse(Console.ReadLine());
			FactoryConversion.Factory(option,peso, appliedConversion);
		}
	}
}