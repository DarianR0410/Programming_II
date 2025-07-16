namespace PracticaFactory;

public class Euro : IConvertTo
{
	public decimal ConvertTo(DominicanPeso peso)
	{
		if (peso.Money > 0)
		{
			decimal result = peso.Money * 0.014m;
			return result;
		} else {
			throw new ArgumentException("Money cannot be negative" + peso.Money);

		}
	}
}