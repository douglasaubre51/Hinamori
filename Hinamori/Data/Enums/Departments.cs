using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Hinamori.Data.Enums;

public enum Departments
{
    [Display(Name = "Computer Engineering")]
    CT,
    [Display(Name = "Electrical & Electronics Engineering")]
    EEE,
    [Display(Name = "Mechanical Engineering")]
    ME,
    [Display(Name = "Electrical Engineering")]
    EE,
    [Display(Name = "Civil Engineering")]
    CE
}