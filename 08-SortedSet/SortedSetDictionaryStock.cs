using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Different products bought and sold in the month
        SortedSet<string> produtosComprados = new SortedSet<string>();
        SortedSet<string> produtosVendidos = new SortedSet<string>();

        // Actual stock of each product
        Dictionary<string, int> stock = new Dictionary<string, int>();

        // Sold quantities of each product
        Dictionary<string, int> quantidadesVendidas = new Dictionary<string, int>();

        
        // TODO: add products to produtosComprados (don't forget to increment stock)

        // TODO: add products to produtosVendidos (don't forget to decrement stock')
        

        Console.WriteLine("PRODUTOS COMPRADOS NO MÊS");
        MostrarSet(produtosComprados);

        Console.WriteLine("PRODUTOS VENDIDOS NO MÊS");
        MostrarSet(produtosVendidos);
        
        Console.WriteLine("STOCK ATUAL");
        MostrarStock(stock);
        
        Console.WriteLine("PRODUTOS COMPRADOS MAS NÃO VENDIDOS");
        var compradosNaoVendidos = new SortedSet<string>(produtosComprados);
        compradosNaoVendidos.ExceptWith(produtosVendidos);
        MostrarSet(compradosNaoVendidos);
        
        
        Console.WriteLine("PRODUTO COM MAIOR STOCK");
        MostrarProdutoMaiorStock(stock);
    }
    
    static void MostrarSet(SortedSet<string> set)
    {
        if (set.Count == 0)
        {
            Console.WriteLine("(sem dados)");
            return;
        }

        foreach (var item in set)
            Console.WriteLine(item);
    }

    static void MostrarStock(Dictionary<string, int> stock)
    {
        foreach (var item in stock.OrderBy(p => p.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value} unidades");
        }
    }

    static void MostrarProdutoMaiorStock(Dictionary<string, int> stock)
    {
        // TODO: implement this method  
        // Console.WriteLine($"{maior.Key} -> {maior.Value} unidades");
    }
    
}
