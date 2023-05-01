using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sua_Carteira.Dados.Entidades {
  [Table("usuarios")]
  public class Usuarios {
    [Key]
    public int usuarioId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
  }
}
