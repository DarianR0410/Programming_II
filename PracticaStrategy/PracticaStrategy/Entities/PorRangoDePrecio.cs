using PracticaStrategy.Interface;

namespace PracticaStrategy.Entities;

public class PorRangoDePrecio : ICalcular
{
	public decimal TarifaFija { get; set; } = 0.5m;
	public decimal CalcularCosto(DTO dto)
	{
		if (dto.PrecioBase >= 5000)
		{
			decimal descuento = dto.PrecioBase * TarifaFija;
			return descuento;
		}

		if (dto.PrecioBase >= 10000)
		{
			decimal descuento = dto.PrecioBase * 0.10m;
			return descuento;
		}
		
		decimal result = TarifaFija * dto.PrecioBase;
		return result;
	}
}