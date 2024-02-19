using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Views;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        var ViewModel = new HomeIndexViewModel();
        ViewData["title"] = ViewModel.Title;

        return View(ViewModel);
    }
}
