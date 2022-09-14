using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Gustavo", "Rua Gustavo da Silveira, n. 12", true),
        new EstudanteViewModel(2, "Pedro", "Rua Zé da Silva, n. 27", false),
        new EstudanteViewModel(3, "Marcos", "Rua de Marte, n. 09", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}