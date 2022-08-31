using API_Projetos.Contexts;
using API_Projetos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Projetos.Repositories
{
    public class ProjetoRepository
    {
        private readonly SqlContext _context;

        public ProjetoRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto p)
        {
            _context.Projetos.Add(p);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto p = _context.Projetos.Find(id);
            _context.Projetos.Remove(p);
            _context.SaveChanges();
        }

        public void Alterar(int id, Projeto p)
        {
            Projeto projetoBuscado = _context.Projetos.Find(id);

            if (projetoBuscado != null)
            {
                projetoBuscado.Titulo = p.Titulo;
                projetoBuscado.Finalizado = p.Finalizado;
                projetoBuscado.Inicio = p.Inicio;
                projetoBuscado.Tecnologia = p.Tecnologia;
                _context.Projetos.Update(projetoBuscado);
                _context.SaveChanges();
            }

        }
    }
}

