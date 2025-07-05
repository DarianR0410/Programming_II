namespace StudentFactory;

class Program
{
	static void Main(string[] args)
	{
		Student student = new Student();
		FileFactory factory = new FileFactory(student);
		
		Console.WriteLine("Document exporter");
		Console.WriteLine("[1] Json Export [2] Text export [3] CSV export");
		int option = int.Parse(Console.ReadLine());
		Console.Write("Enter your ID:");
		int collegeId = int.Parse(Console.ReadLine());
		Console.Write("Enter your Name:");
		string name = Console.ReadLine();
		Console.Write("Enter your Career:");
		string career = Console.ReadLine();
		Student newStudent = new Student();
		newStudent.Name = name;
		newStudent.Career = career;
		newStudent.CollegeId = collegeId;
		factory.CreateExport(option, newStudent);



	}
}