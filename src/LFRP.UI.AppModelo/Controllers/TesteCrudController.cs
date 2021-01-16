using LFRP.UI.AppModelo.Data;
using LFRP.UI.AppModelo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LFRP.UI.AppModelo.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext meuDbContext;

        public TesteCrudController(MeuDbContext meuDbContext)
        {
            this.meuDbContext = meuDbContext;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Luiz Fernando",
                Email = "luiz@gmail.com",
                DataNascimento = DateTime.Now
            };

            meuDbContext.Alunos.Add(aluno);

            meuDbContext.SaveChanges();

            var alunoResult = meuDbContext.Alunos.Find(aluno.Id);

            var aluno3 = meuDbContext.Alunos.FirstOrDefault(a => a.Email == "luiz@gmail.com");

            aluno.Nome = "José";

            meuDbContext.Alunos.Update(aluno);

            meuDbContext.SaveChanges();

            meuDbContext.Alunos.Remove(aluno);

            meuDbContext.SaveChanges();

            return View();
        }
    }
}
