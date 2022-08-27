using Microsoft.EntityFrameworkCore;
using API_Livros.Contexts;
using API_Livros.Models;

namespace API_Livros.Repositories
{
    public class LivroRepository
    {
        private readonly SqlContext _context;

        public LivroRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}

