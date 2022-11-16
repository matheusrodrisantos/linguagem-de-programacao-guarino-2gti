namespace Lanchao.Model;
using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Key]
    public int Id{get;set;}
    
    [Required(ErrorMessage="Nome é obrigatório")]
    public string Nome{get;set;}

    public decimal Preco{get;set;}

    public string Imagem{get;set}

    public string Descricao{get;set;}

    public Categoria Categoria{get;set;}

    public int CategoriaId{get;set;}

}