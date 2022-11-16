namespace Lanchao.Model;
using System.ComponentModel.DataAnnotations;

public class Categoria
{
    [Key]
    public int Id{get;set;}

    [Required(ErrorMessage="Nome da categoria é obrigatório")]
    public string Nome{get;set;}
}