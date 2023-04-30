using Microsoft.EntityFrameworkCore;
using Sua_Carteira.Dados.Entidades;

namespace Sua_Carteira.Dados {
  public class Context : DbContext {

    protected override void OnConfiguring(DbContextOptionsBuilder options) {
      if (!options.IsConfigured) {
        var conexaoStr = "Server=127.0.0.1;Database=suacarteira;Uid=root;";
        options.UseMySql(conexaoStr, ServerVersion.AutoDetect(conexaoStr));
      }
    }

    public DbSet<Contato> Contatos { get; set; }
  }
}
