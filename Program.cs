using System;
using System.Collections.Generic;

namespace test.obj
{
    public class Program
    {
        static void Main(string[] args)
        {   string descricao;
            string fim;
            int quantidade;
            int valor_unitario;

            Pedido p = new List Pedido();
            
         do{

            ItemPedido item = new itemPedido();

                Console.WriteLine("ola, cliente!");

                Console.WriteLine("digite produto!");
                item.descricao = Console.ReadLine();

                Console.WriteLine("digite o valor do produto");
                item.valor_unitario = int.Parse(Console.ReadLine());

                Console.WriteLine("digite a quantidade");
                item.quantidade = int.Parse(Console.ReadLine());

                // criar objeto do tipo pedido e atribuir os valores do campo acima doo tipo itempedido//

                p.Add.listaPedido(item);
                
                Console.WriteLine("deseja adicionar algo mais (sim/nao)");
                fim = Console.ReadLine();

                Console.WriteLine("fim do seu pedido" + p.quantidade, p.valor_unitario, p.quantidade, p.TotalPedido());
            }
             while (fim =="sim"); //enquanto a condiçaoverdadeira//
             
                Console.WriteLine("fim do seu pedido");
                Console.WriteLine("total pedido, tchau" , TotalPedido());
                informarItemPedido();
        }
    
    }
}
