using Microsoft.EntityFrameworkCore;
using UploadArquivo.Models;

namespace UploadArquivo.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {
            //
        }
        public DbSet<Arquivos> Arquivos { get; set; }
    }
}
