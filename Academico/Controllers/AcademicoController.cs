using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class AcademicoController : Controller
    {
        private static List<Aluno> alunos = new List<Aluno>()
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
            var maiorId = alunos.Any() ? alunos.Max(a => a.Id) + 1 : 1;
            aluno.Id = maiorId;
            alunos.Add(aluno);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(alunos.Where(a => a.Id == id).FirstOrDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Aluno aluno)
        {
            alunos.Remove(alunos.Where(A => A.Id == aluno.Id).FirstOrDefault());
            alunos.Add(aluno);
            return RedirectToAction("Index");


        }
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(alunos.Where(a => a.Id == id).FirstOrDefault());
        }
        public IActionResult Delete(int id )
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(alunos.Where(a => a.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Delete(Aluno aluno)
        {
            alunos.Remove(alunos.Where(A => A.Id == aluno.Id).FirstOrDefault());
            return RedirectToAction("Index");


        }
    }
}

