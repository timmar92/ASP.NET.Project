﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Components;

public class SignInModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = "Enter your email", Order = 0)]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password", Order = 1)]
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;


    [Display(Name = "Remember me", Order = 2)]
    public bool RememberMe { get; set; }
}
