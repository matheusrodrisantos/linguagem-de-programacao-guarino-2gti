namespace Lojao.Model;


public class ItemVenda
{
    public int Id{get;set;}

    public int Quantidade{get;set;}

    public Produto Produto{get;set;}

    public Venda Venda{get;set;}
   
}