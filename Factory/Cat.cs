namespace Factory;

public class Cat : IAnimal
{

	public Cat()
	{
		Console.WriteLine("This is a cat");
	}
	public void Sound(string sound)
	{
		sound = "Meaw meaw";
		Console.WriteLine(sound);
	}
}