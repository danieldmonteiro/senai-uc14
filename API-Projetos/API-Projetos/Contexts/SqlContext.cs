using API_Projetos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Projetos.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }
        public SqlContext(DbContextOptions<SqlContext> options)
                : base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=sql1\\local; initial catalog=Chapter;User ID = sa; Password = senhaSECRETA123");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Usuario> Usuarios { get; set;}
    }
}

