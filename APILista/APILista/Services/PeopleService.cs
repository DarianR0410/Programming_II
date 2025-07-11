using APILista.Context;
using APILista.Entities;
using APILista.Interface;
using Microsoft.EntityFrameworkCore;

namespace APILista.Services;

public class PeopleService : IPeople
{
	public readonly ListContext context;

	public PeopleService(ListContext context)
	{
		this.context = context;
	}
	
	public List<People> GetPeople()
	{
		return context.People.ToList();
	}

	public void SetPeople(People people)
	{
		context.People.Add(people);
		context.SaveChanges();
	}

	public void UpdatePeople(People people)
	{
		context.Entry(people).State = EntityState.Modified;
		context.SaveChanges();
	}

	public void RemovePeople(int id)
	{
		var removePeople = context.People.Find(id);
		context.People.Remove(removePeople);
		context.SaveChanges();
	}
}