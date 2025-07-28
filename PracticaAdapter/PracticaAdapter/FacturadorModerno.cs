namespace PracticaAdapter;

public class FacturadorModerno : IFacturador
{
	private decimal _montoBase;
	private decimal _tasaImpuesto;

	public FacturadorModerno(decimal montoBase, decimal tasaImpuesto) 
	{
		_montoBase = montoBase;
		_tasaImpuesto = tasaImpuesto;
	}

	public override string ToString()
	{
		var impuestos = _montoBase * _tasaImpuesto;
		var total = _montoBase + impuestos;

		return $"Monto base: {_montoBase:F2}\n" +
		       $"Impuestos: {impuestos:F2}\n" +
		       $"Total a pagar: {total:F2}";
	}


	public decimal MontoBase { get; set; }
	public decimal TasaImpuesto { get; set; }
}