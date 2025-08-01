using PracticaStrategy.Interface;

namespace PracticaStrategy.Entities;

public class Context
{
	private readonly ICalcular _calcular;

	public Context(ICalcular calcular)
	{
		this._calcular = calcular;
	}

	public decimal Calcular(DTO dto){
		if (_calcular is null)
		{
			throw new ArgumentException("No se puede hacer el calculo de descuentos.");
		}

		var strategy = _calcular.CalcularCosto(dto);
		return strategy;
	}
}