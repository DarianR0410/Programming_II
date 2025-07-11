using APILista.Context;
using APILista.Entities;
using APILista.Interface;
using Microsoft.EntityFrameworkCore;

namespace APILista.Services;

public class AnimalService : IAnimal
{
	private readonly ListContext context;

	public AnimalService(ListContext context)
	{
		this.context = context;
	}
	
	public List<Animal> GetAnimal()
	{
		return context.Animal.ToList();
	}

	public void SetAnimal(Animal animal)
	{
		context.Animal.Add(animal);
		context.SaveChanges();
	}

	public void UpdateAnimal(Animal animal)
	{
		context.Entry(animal).State = EntityState.Modified;
		context.SaveChanges();
	}

	public void RemoveAnimal(int id)
	{
		var removedData = context.Animal.Find(id);
		context.Animal.Remove(removedData);
		context.SaveChanges();
	}
}