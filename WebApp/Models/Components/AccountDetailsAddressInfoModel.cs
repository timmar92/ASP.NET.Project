﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Components;

public class AccountDetailsAddressInfoModel
{
    [Display(Name = "First address", Prompt = "Enter your address", Order = 0)]
    [Required(ErrorMessage = "This address is required")]
    public string AddressLine_1 { get; set; } = null!;


    [Display(Name = "Second address", Prompt = "Enter your second address", Order = 1)]
    public string? AddressLine_2 { get; set; }


    [Display(Name = "Postal code", Prompt = "Enter your postal code", Order = 2)]
    [Required(ErrorMessage = "This address is required")]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; } = null!;


    [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;
}
