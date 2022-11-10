namespace Lojao.Model;


public class Cliente
{
    public int Id{get;set;}

    public string Nome{get;set;}

    public List<Venda> Vendas{get;set;}
   
    public List<Produto> Produtos{get;set;}
}