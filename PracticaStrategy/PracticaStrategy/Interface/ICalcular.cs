using PracticaStrategy.Entities;

namespace PracticaStrategy.Interface;

public interface ICalcular
{
	public decimal TarifaFija { get; set; }
	decimal CalcularCosto(DTO dto);
}