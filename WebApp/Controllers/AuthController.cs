using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Views;

namespace WebApp.Controllers;

public class AuthController(UserService userService) : Controller
{
    private readonly UserService _userService = userService;



    [HttpGet]
    [Route("/signup")]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signup")]
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        ViewData["Title"] = viewModel.Title;
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
            {
                return RedirectToAction("SignIn", "Auth");
            }
        }
        return View(viewModel);
    }

    [HttpGet]
    [Route("/signin")]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signin")]
    public async Task<IActionResult> SignIn(SignInViewModel viewModel)
    {


        ViewData["Title"] = viewModel.Title;
        if (ModelState.IsValid)
        {
            var result = await _userService.SignInUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
            {
                return RedirectToAction("Details", "Account");
            }
        }

        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);

    }

}
