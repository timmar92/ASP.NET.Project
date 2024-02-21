using WebApp.Models.Components;

namespace WebApp.Models.Views;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "images/profile-placeholder.svg",
        FirstName = "John",
        LastName = "Doe",
        Email = "john.Doe@domain.com"
    };
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
}
