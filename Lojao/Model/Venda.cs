namespace Lojao.Model;

public class Venda
{
    public int Id{get;set;}

    public DateTime DataHora{get;set;}

    public Cliente Cliente{get;set;}

    public List<ItemVenda> ItemVendas{get;set;}
   
}