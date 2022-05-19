using Microsoft.EntityFrameworkCore;
using SimpleSign.Models;

namespace SimpleSign.Data
{
    public class BancoContent : DbContext 
    {
        public BancoContent(DbContextOptions<BancoContent> options)
            : base(options)
        { 
        }
        
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ArquivoModel> Arquivos { get; set; }

    }
}
