using WebApp.Models.Components;

namespace WebApp.Models.Views;

public class SignUpViewModel
{
    public string Title { get; set; } = "Sign Up";
    public SignUpModel Form { get; set; } = new SignUpModel();
}
