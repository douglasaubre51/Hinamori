using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hinamori.Data.Enums;

namespace Hinamori.Models;

public class UserInfo
{
    //user details
    [Key]
    public int UserID { get; set; }
    [ForeignKey("LogInfo")]
    public int LogID { get; set; }

    [Required(ErrorMessage = "Please enter your username")]
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    [Compare("Password", ErrorMessage = "passwords do not match!")]
    public string? ConfirmPassword { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string? ProfilePicture { get; set; }
    //college details
    public Departments Department { get; set; }
    public Roles Role { get; set; }
    public Semesters Semester { get; set; }
}