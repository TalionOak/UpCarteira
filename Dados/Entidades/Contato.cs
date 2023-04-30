using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sua_Carteira.Dados.Entidades {

  [Table("contato")]
  public class Contato {
    [Key]
    public int idContato { get; set; }
    public string ContatoCol { get; set; }
    public string Naoo { get; set; }
  }
}