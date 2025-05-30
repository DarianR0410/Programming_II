namespace Figures;

class Program
{
	static void Main(string[] args)
	{
		Circle circleOne = new Circle();
		Circle circleTwo = new Circle();
		Square squareOne = new Square();
		Square squareTwo = new Square();
		Triangle triangleOne = Triangle.GetInstance();
		Triangle triangleTwo = Triangle.GetInstance();

		List<IShape> shapes = new List<IShape>();
		
		shapes.Add(circleOne);
		shapes.Add(circleTwo);
		shapes.Add(squareOne);
		shapes.Add(squareTwo);
		shapes.Add(triangleOne);
		shapes.Add(triangleTwo);

		foreach (var shape in shapes)
		{
			Console.WriteLine(shape.Draw());
		}

		if (triangleOne != triangleTwo)
			Console.WriteLine("No singleton instance created");
		else
			Console.WriteLine("Those are singleton instances");

	}
}