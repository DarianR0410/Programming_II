namespace PracticaAdapter;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("=== Sistema de Facturación ===");

		// Ejemplo actual que ya funciona con la caja
		FacturadorModerno facturador = new FacturadorModerno(1500.00m, 0.18m);
		CajaRegistradora caja = new CajaRegistradora();

		caja.ImprimirFactura(facturador); // Esto ya funciona correctamente

		Console.WriteLine();

		// Aquí debes inc el uso del sistema heredado y aplicar el patrón Adapter
		Console.WriteLine("=== Sistema de Facturación ===");
		SistemaFacturacionLegacy SFL = new SistemaFacturacionLegacy(1600.25m, 0.25m);
		SistemaFacturacionAdapter SFA = new SistemaFacturacionAdapter(SFL);
		CajaRegistradora cajaSFA = new CajaRegistradora();
		
		cajaSFA.ImprimirFactura(SFA);

	}

	}