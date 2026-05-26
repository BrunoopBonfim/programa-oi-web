public class AlunoController : Controller
{
    public IActionResult Index()
    { 
        ViewBag.Nome = "Bruno";
        ViewBag.Curso = "Ads";
        ViewBag.Semestre = "1º";
        return View();
    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.ProdutoId = id;
        ViewBag.Nome = "Aluno ID  + id";
        ViewBag.Curso = "Analise e desenvolvimento de sistemas";
        ViewBag.Semestre = "1º Semestre";
        return View();
    }