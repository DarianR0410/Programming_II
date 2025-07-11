using APILista.Entities;
using APILista.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APILista.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PeopleController : Controller
{
	public readonly IPeople peopleService;
	
	public PeopleController(IPeople peopleService)
	{
		this.peopleService = peopleService;
	}

	[HttpGet("GetPeople")]
	public List<People> GetPeoples()
	{
		return peopleService.GetPeople();
	}

	[HttpPost("SetPeople")]
	public void SetPeople(People people)
	{
		peopleService.SetPeople(people);
	}

	[HttpPut("UpdatePeople")]
	public void UpdatePeople(People people)
	{
		peopleService.UpdatePeople(people);
	}

	[HttpDelete("DeletePeople")]
	public void RemovePeople(int id)
	{
		peopleService.RemovePeople(id);
	}
}