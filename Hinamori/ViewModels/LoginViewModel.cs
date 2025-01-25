using System;
using Hinamori.Models;

namespace Hinamori.ViewModels;

public class LoginViewModel : UserInfo
{
    public string? EmailValidation { get; set; }
    public string? PasswordValidation { get; set; }
}