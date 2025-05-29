using Practica1.Entities;

namespace Practica1.Repositories;

public class OwnerRepository
{
	public Owner owner;
	public Pet pet;
	private List<Owner> owners;

	public OwnerRepository()
	{
		owner = new Owner();
		pet = new Pet();
		owners = new List<Owner>();
	}

	public void AddOwner(string name, string lastName, int phoneNumber, Pet pet)
	{
		owner.name = name;
		owner.lastName = lastName;
		owner.phoneNumber = phoneNumber;
		owner.pet = pet;

		owners.Add(owner);
	}

	public Owner UpdateOwner(String name, String lastName, int phoneNumber, Pet pet)
	{
		if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || phoneNumber < 1)
			return null;
		for (int i = 0; i < owners.Count; i++)
		{
			if (owner.name == owners[i].name && owner.lastName == owners[i].lastName &&
			    owners[i].phoneNumber == phoneNumber)
			{
				owners[i].phoneNumber = phoneNumber;
				owners[i].pet = pet;
				
				return owners[i];
			}
		}

		return null;
	}
	
	public Owner DeleteOwner(string name, string lastName)
	{
		if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName))
			return null;
		for (int i =0; i < owners.Count; i++)
		{
			if(owner.name == owners[1].name && owner.lastName == owners[i].lastName)
			{
				owners.RemoveAt(i);
				return owners[i];
			}
			
		}

		return null;
	}
	
	public Owner GetOwner(string name, string lastName)
	{
		if(string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(lastName))
		return null;

		for (int i = 0; i < owners.Count ; i++)
		{
			if (owner.name == owners[i].name && owner.lastName == owners[i].lastName)
			{
				return owners[i];
			}
		}

		return null;
	}
	
	public List<Owner> GetOwners()
	{
		return owners;
	}
}