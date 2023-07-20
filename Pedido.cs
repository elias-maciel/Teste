using System;
using System.Collections.Generic;

namespace test.obj
{
 public class Pedido
   { 
     public string descricao;
     public int valor_unitario, quantidade;

     private List<ItemPedido> listaPedido = new List<ItemPedido>();

        public Pedido()
        {
            listaPedido = new List<ItemPedido>();//construtor
        }
        public Pedido(string d, int vu, int q)
        {
            descricao = d;
            valor_unitario = vu ;
            quantidade = q ;
            Console.WriteLine("siga as instruções!!!!");
        }
        public addLista(ItemPedido item)
        {
        Add.listaPedido(item);  
        //recebendo novo item nessa funçao//
        }

        public void informarItemPedido()
        {  
              foreach(ItemPedido item in listaPedido)
            {
                Console.WriteLine("segue lista dos itens de seu pedido", item);
            }
        }
        public int TotalPedido()
        {
            int totalPedido = 0;
            
            foreach (ItemPedido item in listaPedido)
            {
                totalPedido = quantidade *= valor_unitario;
            }
           return totalPedido ;
        }
    }
}