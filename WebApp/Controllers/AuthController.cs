using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Views;

namespace WebApp.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        ViewData["Title"] = "Sign Up";
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        ViewData["Title"] = "Sign Up";
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }
        return RedirectToAction("SignIn", "Auth");
    }

}
