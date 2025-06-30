using API_Sample.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API_Sample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonaController : Controller
{
	private readonly IPersona service;

	public PersonaController(IPersona service)
	{
		this.service = service;
	}
	
	[HttpGet]
	public IEnumerable<Persona> GetPersonas()
	{
		return service.GetPersonas();
	}
}