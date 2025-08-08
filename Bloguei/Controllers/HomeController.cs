using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bloguei.Models;

namespace Bloguei.Controllers;

//: Controller: herda da classe Controller, ou seja, essa classe ganha todos os comportamentos básicos de um controller do ASP.NET MVC
public class HomeController : Controller
{
    // Cria um objeto chamado logger que é somente de leitura. 
    private readonly ILogger<HomeController> _logger;

    // Método construtor: cria objeto na memória
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "Divas!";
        // Criar objetos
        Categoria categoria = new();
        categoria.Id = 1;
        categoria.Nome = "Closet dos Sonhos";

        Categoria categoria2 = new()
        {
            Id = 2,
            Nome = "Glow Up"
        };

        List<Postagem> postagens = [
            new(){
                Id = 1,
                Nome = "Seja a nova Malu Borges com essas super tendências!",
                CategoriaId = 1,
                Categoria = categoria,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Labubu",
                Texto = "Lorem ipsum"
            }
        ];

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
