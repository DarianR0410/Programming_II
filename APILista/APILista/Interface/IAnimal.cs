using APILista.Entities;

namespace APILista.Interface;

public interface IAnimal
{
	List<Animal> GetAnimal();
	void SetAnimal(Animal animal);
	void UpdateAnimal(Animal animal);
	void RemoveAnimal(int id);
}