namespace UniqueCodes;

public class CodeGenerator
{

	public List<int> generateCode { get; set; }
	
	private CodeGenerator()
	{
		generateCode = new List<int>();
	}
	
	private static CodeGenerator instance;

	public static CodeGenerator Instance()
	{
		if (instance == null)
		{
			instance = new CodeGenerator();
		}
		
		return instance;
	}
	
	
	
	public int GenerateCode()
	{
		int newCode = generateCode.Count + 1;
		generateCode.Add(newCode);
		return newCode;

	}

}