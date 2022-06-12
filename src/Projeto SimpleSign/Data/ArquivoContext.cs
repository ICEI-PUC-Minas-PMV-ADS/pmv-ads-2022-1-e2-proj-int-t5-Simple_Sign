using Microsoft.EntityFrameworkCore;
using SimpleSign.Models;

namespace SimpleSign.Data
{
    public class ArquivoContext : DbContext
    {
        public ArquivoContext(DbContextOptions<ArquivoContext> options)
            : base(options)
        {
        }

        public DbSet<ArquivosModel> Arquivos { get; set; }
        


    }
}
