using System;

namespace API.Models;

public class AppUser
{
    public AppUser(int id, string userName, string? email, string password)
    {
        Id = id;
        UserName = userName;
        Email = email;
        Password = password;
    }

    public int Id { get; set; }
  
    public required string UserName { get; set; }
    public string? Email { get; set; }
    public string Password { get; set; } = "";
}
