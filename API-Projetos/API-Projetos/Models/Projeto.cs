using Microsoft.EntityFrameworkCore;
namespace API_Projetos.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public bool Finalizado { get; set; }
        public int Inicio { get; set; }
        public string? Tecnologia { get; set; }
        
    }
}

