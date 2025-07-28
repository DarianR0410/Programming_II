namespace PracticaAdapter;

public class CajaRegistradora
{
	public void ImprimirFactura(IFacturador facturador)
	{
		// La caja registradora espera imprimir:
		// Monto base: XXXX.XX
		// Impuestos: XXXX.XX
		// Total a pagar: XXXX.XX

		Console.WriteLine(facturador);
	}
}