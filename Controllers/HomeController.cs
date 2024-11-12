using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;
using System.Diagnostics;

namespace ProjetoMVC.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        HomeModel home = new HomeModel();

        home.Nome = "Fábio Flauzino";
        home.Email = "fabioflauzino@hotmail.com";

        return View(home);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
