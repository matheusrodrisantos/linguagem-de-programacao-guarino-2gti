namespace Lanchao.Model;

public class Pedido
{
    public int Id{get;set;}

    public int Numero{get;set;}

    public DateTime DataHora{get;set;}

    public string Obervacao{get;set;}
    
    public string Origem{get;set;}

    public int TempoEntrega{get;set;}

    public Cliente Comprador{get;set;}
    
    public List<Produto> Produtos{get;set;}

}