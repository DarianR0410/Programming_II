namespace PracticaAdapter;

public class SistemaFacturacionAdapter : IFacturador
{
	private SistemaFacturacionLegacy SFL;

	public SistemaFacturacionAdapter(SistemaFacturacionLegacy legacy)
	{
		SFL = legacy;
	}
	
	public override string ToString()
	{
		var LegacySFC = SFL.CalcularDetalle();
		return $"Monto base: {SFL.MontoBase :F2}\n" +
		       $"Impuestos: {SFL.Impuesto :F2}\n" + 
		       $"Total a pagar: {LegacySFC.Total :F2}";
	}


}