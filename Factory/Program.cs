namespace Factory;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to the Factory!");
		Console.WriteLine("We specify on recognizing animals, please type he sound of your animal:");
		string sound = Console.ReadLine();

		AnimalFactory factory = new AnimalFactory();
		IAnimal animal = factory.CreateAnimal(sound);
		Console.WriteLine(animal);
	}
}