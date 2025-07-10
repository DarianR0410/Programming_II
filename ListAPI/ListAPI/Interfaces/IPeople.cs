using ListAPI.Entities;

namespace ListAPI.Interfaces;

public interface IPeople
{
	List<People> GetPeople();
	void SetPeople(People people);
	void UpdatePeople(People people);
	void RemovePeople(People people);
	
}