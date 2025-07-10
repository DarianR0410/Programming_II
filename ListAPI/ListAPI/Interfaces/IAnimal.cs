using ListAPI.Entities;

namespace ListAPI.Interfaces;

public interface IAnimal
{
	List<Animal> GetAnimal();
	void SetAnimal(Animal animal);
	void UpdateAnimal(Animal animal);
	void RemoveAnimal(Animal animal);
	
	
}