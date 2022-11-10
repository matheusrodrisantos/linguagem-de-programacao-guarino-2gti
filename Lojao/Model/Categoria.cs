namespace Lojao.Model;

public class Categoria
{
    public int Id{get;set;}

    public string Descricao{get;set;}

    public List<Produto> Produtos{get;set;}
   
}