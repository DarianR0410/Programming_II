using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Entities;

[Table("Users")]
public class User
{
    [Column ("idUser", TypeName = "int")]
    [Key]
    public int idUser { get; set; }
    [Column ("name")]
    public String name { get; set; }
    [Column ("LastName")]
    public String lastName { get; set; }

    public User()
    {
        
    }
    
    public User(int idUser, String name, String lastName)
    {
        this.idUser = idUser;
        this.name = name;
        this.lastName = lastName;
    }

    public void UserInformation()
    {
        Console.WriteLine("User Information:");
        Console.WriteLine("ID: " + idUser);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Last Name: " + lastName);
    }

    public void SetUserInformation(String name, String lastName)
    {
        this.name = name;
        this.lastName = lastName;
    }
}