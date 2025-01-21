using System;

namespace Hinamori.Models;

public class Login : UserInfo
{
    public string? EmailValidation { get; set; }
    public string? PasswordValidation { get; set; }
}