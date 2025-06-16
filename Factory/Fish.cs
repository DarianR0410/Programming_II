namespace Factory;

public class Fish : IAnimal
{

	public Fish()
	{
		Console.WriteLine("This is a fish");
	}
	public void Sound(string sound)
	{
		sound = "Bloop bloop";
		Console.WriteLine(sound);
	}
}