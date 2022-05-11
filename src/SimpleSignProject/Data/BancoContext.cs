using Microsoft.EntityFrameworkCore;
using SimpleSign.Models;

namespace SimpleSign.Data
{
    public class BancoContext : DbContext 
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        { 
        }
        
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AssinaturaModel> Assinaturas { get; set; }
        public DbSet<DocumentoModel> Documentos { get; set; }

    }
}
