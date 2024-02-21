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

    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewModel)
    {


        ViewData["Title"] = viewModel.Title;
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        //var result = _authService.SignIn(viewModel.Form);
        //if (result)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);

    }

}
