using PracticaStrategy.Interface;

namespace PracticaStrategy.Entities;

public class PorMiembroDeClub : ICalcular
{
	public decimal TarifaFija { get; set; } = 0.20m;
	public decimal CalcularCosto(DTO dto)
	{
		decimal resultado = dto.PrecioBase * TarifaFija;
		return resultado;
	}
}