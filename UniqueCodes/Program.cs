namespace UniqueCodes;

class Program
{
	static void Main(string[] args)
	{
		CodeGenerator codeGenerator = CodeGenerator.Instance();
		bool isRunning = true;

		while (isRunning)
		{
			Console.WriteLine("Would you like to generate a unique code? (y/n)");
			char option = Console.ReadKey().KeyChar;

			if (option == 'y')
			{
				Console.WriteLine("Unique code generated: " + codeGenerator.GenerateCode());
			}
			else
			{
				isRunning = false;
			}
		}

	}
}