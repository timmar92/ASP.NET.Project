using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Views;

namespace WebApp.Controllers;

public class AccountController : Controller
{
    //private readonly AccountService _accountService;

    //public AccountController(AccountService accountService)
    //{
    //    _accountService = accountService;
    //}

    [Route("/")] //change this to /account/details later
    public IActionResult Details()
    {
        var viewModel = new AccountDetailsViewModel();
        return View(viewModel);
    }
}
