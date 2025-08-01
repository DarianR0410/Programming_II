using PracticaStrategy.Entities;
using PracticaStrategy.Interface;

namespace PracticaStrategy.Service;

public class CalcularPrecioServices
{
	private readonly ICalculadorFactory _calculadorFactory;
    
	public CalcularPrecioServices(ICalculadorFactory calculadorFactory)
	{
		_calculadorFactory = calculadorFactory;
	}
    
	public decimal Calcular(DTO dto)
	{
		try
		{
			var context  = _calculadorFactory.CreateContext(dto.EstimacionDeDescuento);
			var montoDescuento = context.Calcular(dto);
			var precioFinal = dto.PrecioBase - montoDescuento;
			return precioFinal < 0 ? 0 : precioFinal;
		}
		catch (ArgumentException)
		{
			return dto.PrecioBase;
		}
	}
}