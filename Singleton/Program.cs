namespace Singleton;

class Program
{
	static void Main(string[] args)
	{
		Administrador admin = Administrador.GetInstance();
		admin.Rol("Soy administrador");
		Administrador admin2 = Administrador.GetInstance();
		admin2.Rol("Soy otro administrador");
		
		// Verifica que ambas instancias son la misma
		Console.WriteLine(admin == admin2);
		
		// Hacemos lo mismo con los demas roles.

		Empleado empleado1 = new Empleado();
		empleado1.Rol("empleado 1");
		Empleado empleado2 = new Empleado();
		empleado1.Rol("empleado 2");
		
		Console.WriteLine(empleado1 == empleado2);
		
		Cliente cliente1 = new Cliente();
		cliente1.Rol("cliente 1");
		Cliente cliente2 = new Cliente();
		cliente1.Rol("cliente 2");
		
		Console.WriteLine(cliente1 == cliente2);
		
		Proveedor proveedor1 = new Proveedor();
		proveedor1.Rol("proveedor 1");
		Proveedor proveedor2 = new Proveedor();
		proveedor1.Rol("proveedor 2");
		
		Console.WriteLine(proveedor1 == proveedor2);
		
		//Como conclusion tenemos que en los objetos Empleado, Cliente y Proveedor se tienen mas de una instanciacion, por esto el resultado al comparar nos da como resultado False.
		// En el caso de Administrador, al ser un singleton, solo se puede instanciar una vez, por lo que al comparar nos da como resultado True.
		
	}
}