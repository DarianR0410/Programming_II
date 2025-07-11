using APILista.Entities;

namespace APILista.Interface;

public interface IPeople
{
	List<People> GetPeople();
	void SetPeople(People people);
	void UpdatePeople(People people);
	void RemovePeople(int id);
}