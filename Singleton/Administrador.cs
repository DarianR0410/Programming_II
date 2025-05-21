namespace Singleton;

public sealed class Administrador
{
	private static Administrador instance;
	private static readonly object padlock = new object();
	
	private Administrador()
	{
		// Constructor privado para evitar instanciación externa.
	}

	public static Administrador GetInstance()
	{
		lock (padlock)
		{
			if (instance == null)
			{
				instance = new Administrador();
			}
		}

		return instance;
	}

	public void Rol(String rol)
	{
		Console.WriteLine("Mi rol es administrador");
	}
		}