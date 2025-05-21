namespace Singleton;

public class Proveedor
{
	private String proveedor;
	
	public Proveedor()
	{
		this.proveedor = "Proveedor";
	}
	
	public void Rol(String rol)
	{
		Console.WriteLine("Mi rol es.. " + rol);
	}
}