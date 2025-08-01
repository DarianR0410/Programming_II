using PracticaStrategy.Interface;

namespace PracticaStrategy.Entities;

public class PorCategoria : ICalcular
{
	public decimal TarifaFija { get; set; } = 0.10m;
	public decimal CalcularCosto(DTO dto)
	{
		if (dto.Categoria == "Hogar")
		{
			TarifaFija = 0.30m;
			var descuentoPorHogar = dto.PrecioBase * TarifaFija;
			return descuentoPorHogar;
		}

		if (dto.Categoria == "Electronica")
		{
			TarifaFija = 0.30m;
			var descuentoPorElectronica = dto.PrecioBase * TarifaFija;
			return descuentoPorElectronica;
		}
		
		var descuento = dto.PrecioBase * TarifaFija;
		return descuento;
	}
}