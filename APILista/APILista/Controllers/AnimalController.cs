using APILista.Entities;
using APILista.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APILista.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : Controller
{
	public readonly IAnimal animalService;

	public AnimalController(IAnimal animalService)
	{
		this.animalService = animalService;
	}

	[HttpGet("Get_Animal")]
	public List<Animal> GetAnimal()
	{
		return animalService.GetAnimal();
	}

	[HttpPost("Add_Animal")]
	public void SetAnimal(Animal animal)
	{ 
		animalService.SetAnimal(animal);
	}

	[HttpPut("Update_Animal")]
	public void UpdateAnimal(Animal animal)
	{
		animalService.UpdateAnimal(animal);
	}

	[HttpDelete("Remove_Animal")]
	public void RemoveAnimal(int id)
	{
		animalService.RemoveAnimal(id);
	}
}