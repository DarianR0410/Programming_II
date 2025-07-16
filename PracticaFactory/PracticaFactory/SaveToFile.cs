namespace PracticaFactory;

public class SaveToFile
{
	
	public static void SaveToTxt(DominicanPeso peso, IConvertTo convertTo, string appliedConversion)
	{
		string path = "C:\\Users\\Darian Ramos\\C#\\PracticaFactory\\PracticaFactory\\SaveConversion\\Save.txt";
		
		StreamWriter sw = new StreamWriter(path);
		sw.Write("**************************************" +  "\n");
		sw.Write("Date and Time: " + DateTime.Now+ "\n");
		sw.Write("Converted to: " + appliedConversion + "\n");
		sw.Write("Dominican peso amount: " + peso.Money  + "\n");
		sw.Write("Conversion result: " + convertTo.ConvertTo(peso) + "\n");
		sw.Write("**************************************" +  "\n");
		sw.Close();
	}
}