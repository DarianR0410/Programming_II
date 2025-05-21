namespace Singleton;

public class Empleado : Persona
{
	private String rol;

	public Empleado()
	{
		this.rol = "Empleado";
	}

	public void Rol(String rol)
	{
		Console.WriteLine("Mi rol es.. " + rol);
	}
}