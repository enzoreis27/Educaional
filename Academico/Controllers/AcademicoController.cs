using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class AcademicoController : Controller
    {
        private static List<Aluno> alunos= new List<Aluno>()
        {
          new Aluno { Id = 1, Nome = "Enzo",email = "brunoplay@gmail.com", DataNascimento = new DateTime(2006,10,06)},
        };
        public IActionResult Index()
        {
            return View(alunos);

        }

        public IActionResult Create()
            {
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Aluno aluno)
        {
            aluno.Id = alunos.Count + 1;
            alunos.Add(aluno);
            return RedirectToAction("Index");
        }
    }
}
