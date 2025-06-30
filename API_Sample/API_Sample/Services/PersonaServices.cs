using API_Sample.Interfaces;

namespace API_Sample.Services;

public class PersonaServices : IPersona
{
	public List<Persona> GetPersonas()
	{
		List<Persona> personas = new List<Persona>();
		personas.Add(new Persona { Nombre = "Darian", Correo = "test@testing.com"});
		personas.Add(new Persona { Nombre = "Juan", Correo = "test2@testing.com"});
		personas.Add(new Persona { Nombre = "Miguel", Correo = "test3@testing.com"});

		return personas;
	}
}