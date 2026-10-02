using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
    public IActionResult Index()
    {
        ViewData["Titulo"] = "Especialidades da Clínica Vida+";

        return View();
    }
}