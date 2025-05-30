namespace Figures;

public class Triangle : IShape
{

	private Triangle(){}

	private static Triangle instance;
	
	public static Triangle GetInstance()
	{
		if (instance == null)
			instance = new Triangle();
		return instance;
	}
	
	public string Draw( )
	{
		string message = "I'm a triangle";

		return message;
	}
}