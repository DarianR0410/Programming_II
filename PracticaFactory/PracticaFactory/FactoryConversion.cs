namespace PracticaFactory;

public class FactoryConversion
{

	public static IConvertTo Factory(int option, DominicanPeso peso, string appliedConversion)
	{
		if (option == 1)
		{
			IConvertTo convertToEuro = new Euro();
			convertToEuro.ConvertTo(peso);
			SaveToFile.SaveToTxt(peso, convertToEuro,appliedConversion);
			return convertToEuro;
		} else if (option == 2)
		{
			IConvertTo convertToDollar = new Dollar();
			convertToDollar.ConvertTo(peso);
			SaveToFile.SaveToTxt(peso, convertToDollar,appliedConversion);
			return convertToDollar;
		}
		else
		{
			IConvertTo convertToColombianPeso = new ColombianPeso();
			convertToColombianPeso.ConvertTo(peso);
			SaveToFile.SaveToTxt(peso, convertToColombianPeso,appliedConversion);
			return convertToColombianPeso;
		}
	}
}