namespace Practica1.Entities;

public class Owner
{
	public string name { get; set; }
	public string lastName { get; set; }
	public int phoneNumber { get; set; }
	public Pet pet;

	public Owner()
	{
		pet = new Pet();
	}
}