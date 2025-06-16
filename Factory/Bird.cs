namespace Factory;

public class Bird : IAnimal 
{

	public Bird()
	{
		Console.WriteLine("This is a bird");
	}
	
	public void Sound(string sound)
	{
		sound = "Coo coo";
		Console.WriteLine(sound);
		
	}
}