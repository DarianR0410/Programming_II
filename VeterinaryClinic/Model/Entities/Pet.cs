namespace Practica1.Entities;

public class Pet
{
	public string name { get; set; }
	public string species { get; set; }
	public int age { get; set; }
	public Owner owner;
	
	public Pet()
	{
		owner = new Owner();
	}
}