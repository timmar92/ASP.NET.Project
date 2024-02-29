using Infrastructure.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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
                var userModel = (UserModel)result.ContentResult!;
                var claims = new List<Claim>
                {
                    new(ClaimTypes.NameIdentifier, userModel.Id),
                    new(ClaimTypes.Name, userModel.Email),
                    new(ClaimTypes.Email, userModel.Email)
                };

                await HttpContext.SignInAsync("AuthCookie", new ClaimsPrincipal(new ClaimsIdentity(claims, "AuthCookie")));
                return RedirectToAction("Details", "Account");
            }
        }

        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);

    }

    [HttpGet]
    public new async Task<IActionResult> SignOut()
    {
        await HttpContext.SignOutAsync("AuthCookie");
        return RedirectToAction("SignIn", "Auth");
    }

}
