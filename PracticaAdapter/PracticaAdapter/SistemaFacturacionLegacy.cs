namespace PracticaAdapter;

public class SistemaFacturacionLegacy
{
	private decimal _montoBase;
	private decimal _tasaImpuesto;

	public SistemaFacturacionLegacy(decimal montoBase, decimal tasaImpuesto)
	{
		_montoBase = montoBase;
		_tasaImpuesto = tasaImpuesto;
	}

	public decimal MontoBase => _montoBase;
	public decimal Impuesto => _tasaImpuesto;

	public DetalleFactura CalcularDetalle()
	{
		var impuestos = _montoBase * _tasaImpuesto;
		var total = _montoBase + impuestos;

		return new DetalleFactura
		{
			Impuestos = impuestos,
			Total = total
		};
	}

}