using Microsoft.AspNetCore.Mvc;
using PracticaStrategy.Entities;
using PracticaStrategy.Service;

namespace PracticaStrategy.Controllers;

[ApiController]
[Route("[controller]")]
public class CalcularPrecioController : ControllerBase
{
	private readonly CalcularPrecioServices _calcularPrecioServices;

	public CalcularPrecioController(CalcularPrecioServices calcularPrecioServices)
	{
		_calcularPrecioServices = calcularPrecioServices;
	}
	
	[HttpPost]
	public IActionResult Index(DTO dto)
	{
		var precio =  _calcularPrecioServices.Calcular(dto);
		return Ok(precio);
	}
}