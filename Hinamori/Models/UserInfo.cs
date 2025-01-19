using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hinamori.Models;

public class UserInfo
{
    //user details
    [Key]
    public int UserID { get; set; }
    [ForeignKey("LogInfo")]
    public int LogID { get; set; }

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