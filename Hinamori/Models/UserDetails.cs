using System;
using System.ComponentModel.DataAnnotations;

namespace Hinamori.Models;

public class UserDetails
{
    //user details
    [Key]
    public string UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string ProfilePicture { get; set; }
    //college details
    public string Role { get; set; }
    public string Course { get; set; }
    public string Semester { get; set; }
}