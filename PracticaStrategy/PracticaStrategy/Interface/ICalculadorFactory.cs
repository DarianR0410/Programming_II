using PracticaStrategy.Entities;

namespace PracticaStrategy.Interface;

public interface ICalculadorFactory
{
	Context CreateContext(string estimacionDeDescuento);
}