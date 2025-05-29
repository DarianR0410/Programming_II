using Practica1.Entities;

namespace Practica1.Repositories;

public class PetRepository
{
	public Pet pet;
	public Owner owner;
	private List<Pet> pets;
	
	public PetRepository()
	{
		pet = new Pet();
		owner = new Owner();
		pets = new List<Pet>();
	}

	public Pet AddPet(String ownerName, String name, String species, int age)
	{
		if (String.IsNullOrWhiteSpace(ownerName) || String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(species) || age < 0)
		{
			throw new ArgumentException("To register your pet, you must provide all the information requested.");
		}
		else
		{
			pets.Add(pet);
		}

		return null;
	}

	public Pet UpdatePet(string newName, int newAge, string ownerName, string petName)
	{

		if (string.IsNullOrWhiteSpace(newName) || newName.Length > 0 || newAge < 0)
			return null;
		
		for (int i = 0; i < pets.Count; i++)
		{
			if (owner.name == pets[i].owner.name && pet.name == pets[i].name)
			{
				pets[i].name = newName;
				pets[i].age = newAge;
				return pets[i];
			}
			
		}

		return null;
	}

	public Pet DeletePet(String ownerName, String petName)
	{

		for(int i = 0; i < pets.Count; i++)
		{
			if (ownerName == pets[i].owner.name && petName == pets[i].name)
			{
				pets.RemoveAt(i);
				return pets[i];

			}
		}

		return null;
	}
	

	public Pet GetPet(string ownerName, string petName)
	{
		if (string.IsNullOrWhiteSpace(ownerName) || string.IsNullOrWhiteSpace(petName))
			return null; 
		
		for (int i = 0; pets.Count > i; i++) 
		{
			if (ownerName == pets[i].owner.name && petName == pets[i].name)
			{
				return pets[i];
				
			}
		}

		return null;
	}
	
	public List<Pet> GetPets()
	{
		return pets;
	}
}