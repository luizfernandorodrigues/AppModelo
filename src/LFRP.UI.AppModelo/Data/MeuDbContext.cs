using LFRP.UI.AppModelo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LFRP.UI.AppModelo.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
