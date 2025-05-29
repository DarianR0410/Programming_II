using Practica1.Entities;

namespace Practica1.Repositories;

public class AppointmentRepository
{
	public Appointment Appointment;
	public Pet pet;
	public Vet vet;
	private List<Appointment> dates;
	
	public AppointmentRepository()
	{
		Appointment = new Appointment();
		pet = new Pet();
		vet = new Vet();
		dates = new List<Appointment>();
	}
	
	public void AddAppointment()
	{
		// Logic to add a date
	}
	
	public void UpdateAppointment()
	{
		// Logic to update a date
	}
	
	public void DeleteAppointment()
	{
		// Logic to delete a date
	}
	
	public void GetAppointment()
	{
		// Logic to get a specific date
	}
	
	public List<Appointment> GetAppointments()
	{
		return dates;
	}
}