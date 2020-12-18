using System;
using Interfaces18.Classes;

namespace Interfaces18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Carrinho cart =  new Carrinho();
            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Name = "Playstation 5 ";
            p1.Preco = 10000;

            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Name = "Box Series x ";
            p2.Preco = 5000;

            Produto p3 = new Produto();
            p3.Codigo = 125;
            p3.Name = "Nintendo Switch ";
            p3.Preco = 3000;

            cart.Cadastrar(p1);
            cart.Cadastrar(p2);
           // cart.Cadastrar(p3);
            cart.Listar();

           
            Console.WriteLine("--------------------------------");

            //Adicionar uma cor a parte para o código
            Console.ForegroundColor = ConsoleColor.Yellow;
            
             //Alterar um produto pelo código
            cart.Alterar(p2.Codigo, p3);
            cart.Listar();

        }
    }
}
