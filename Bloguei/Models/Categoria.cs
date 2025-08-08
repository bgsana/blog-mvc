using System.ComponentModel.DataAnnotations;

namespace Bloguei.Models;

public class Categoria
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(30)]
    public string Nome { get; set; }
}
