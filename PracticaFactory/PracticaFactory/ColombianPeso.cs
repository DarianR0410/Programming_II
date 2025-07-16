namespace PracticaFactory;

public class ColombianPeso : IConvertTo
{
	public decimal ConvertTo(DominicanPeso peso)
	{
		if (peso.Money > 0)
		{
			decimal result = peso.Money * 66.56m;
			return result;
		}
		else
		{
			throw new ArgumentException("Money cannot be negative" + peso.Money);
		}
	}
	
}