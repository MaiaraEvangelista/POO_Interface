using System;
using System.Collections.Generic;

namespace Interfaces18.Classes
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int cod, Produto novoProduto)
        {
            //Lambda
            carrinho.Find(x => x.Codigo == cod).Name = novoProduto.Name;
            carrinho.Find(x => x.Codigo == cod).Preco = novoProduto.Preco;
            carrinho.Find(x => x.Codigo == cod).Codigo = novoProduto.Codigo;
        }

        public void Cadastrar(Produto produto)
        {
           carrinho.Add(produto);
        } 

        public void Deletar(int cod)
        {
            Produto prodDelete = carrinho.Find(x => x.Codigo == cod);
            if (prodDelete != null)
            {
                carrinho.Remove(prodDelete);
            }
        }

        public void Listar()
        {
           foreach (Produto item in carrinho)
           {
               Console.WriteLine("Produto :" + item.Name);
               Console.WriteLine("Preco :" + item.Preco);
               Console.WriteLine("Cód :" + item.Codigo);
           }
        }
    }
}