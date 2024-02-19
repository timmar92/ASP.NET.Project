using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AuthController : Controller
{
    [Route("signup")]
    public IActionResult SignUp()
    {
        ViewData["Title"] = "Sign Up.";
        return View();
    }

    //public IActionResult SignIn()
    //{
    //    ViewData["Title"] = "Sign In.";
    //    return View();
    //}


    //public new IActionResult SignOut()
    //{
    //    return RedirectToAction("Index", "Home");
    //}
}
