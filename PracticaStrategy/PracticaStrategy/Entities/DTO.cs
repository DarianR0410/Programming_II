using System.Text.Json.Serialization;

namespace PracticaStrategy.Entities;

public class DTO
{
	public decimal PrecioBase { get; set; } = 0;
	[JsonPropertyName("categoria")]
	public string? Categoria { get; set; } = string.Empty;
    
	[JsonPropertyName("miembroClub")]
	public bool EsMiembroDeClub { get; set; } = false;
    
	[JsonPropertyName("modoEstimacionDescuento")]
	public string EstimacionDeDescuento { get; set; } = string.Empty;

}