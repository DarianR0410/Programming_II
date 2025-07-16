namespace PracticaFactory;

public class Dollar : IConvertTo
{
	public decimal ConvertTo(DominicanPeso peso)
	{
		if (peso.Money > 0)
		{
			decimal result = peso.Money * 0.17m;
			return result;
		}
		else
		{
			throw new ArgumentException("Money cannot be negative" + peso.Money);
		}

	}
}