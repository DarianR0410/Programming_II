namespace Factory;

internal class AnimalFactory
{
	public IAnimal CreateAnimal(string sound)
	{
		if (sound == "Meaw meaw")
		{
			return new Cat();
		}

		if (sound == "Bloop bloop")
		{
			return new Fish();
		}
		else
		{
			return new Bird();
		}
		
		
	}
}