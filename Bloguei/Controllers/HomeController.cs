using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bloguei.Models;

namespace Bloguei.Controllers;

//: Controller: herda da classe Controller, ou seja, essa classe ganha todos os comportamentos básicos de um controller do ASP.NET MVC
public class HomeController : Controller
{
    // Cria um objeto chamado logger que é somente de leitura. 
    private readonly ILogger<HomeController> _logger;

    //Método construtor: cria objeto na memória
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
