namespace Practica1.Entities;

public class Appointment
{
	public Owner owner;
	public Pet pet;
	public Vet vet;
	public Treatment treatment;
	
	public DateTime date { get; set; }
	
	public Appointment()
	{
		owner = new Owner();
		pet = new Pet();
		vet = new Vet();
		treatment = new Treatment();
	}
}