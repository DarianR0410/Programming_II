using PracticaStrategy.Interface;

namespace PracticaStrategy.Entities;

public class CalculadoraFactory : ICalculadorFactory
{
	public Context CreateContext(string estimacionDeDescuento)
	{
		return estimacionDeDescuento switch
		{
			"PorCategoria" => new Context(new PorCategoria()),
			"PorMiembroDeClub" => new Context(new PorMiembroDeClub()),
			"PorEstimacionDeDescuento" => new Context(new PorRangoDePrecio()),
			_ => throw new ArgumentException($"Tipo de descuento no válido: {estimacionDeDescuento}")
		};
	}
}