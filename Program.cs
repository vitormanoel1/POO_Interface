using System;
using POO_Interface.Classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Fifa 2021";
            p1.Preco = 350;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "Pes 2021";
            p2.Preco = 400;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "GTA V";
            p3.Preco = 300;

            Produto p4 = new Produto();
            p4.Codigo = 4;
            p4.Nome = "GTA San Andreas";
            p4.Preco = 280;

            cart.Cadastrar(p1);
            cart.Listar();
            cart.Cadastrar(p2);
            cart.Alterar(p1.Codigo, p2);
            cart.Listar();
        }
    }
}
