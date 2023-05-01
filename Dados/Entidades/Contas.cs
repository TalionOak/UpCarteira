using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sua_Carteira.Dados.Entidades {
  [Table("contas")]
  public class Contas {
    [Key]
    public int contaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Saldo { get; set; }
    public string Icone { get; set; }
    public bool IncluirSaldo { get; set; }
    public DateTime CriadoEm { get; set; }
    public int UsuarioFk { get; set; }
  }
}