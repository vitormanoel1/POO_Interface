using System;
using System.Collections.Generic;

namespace POO_Interface.Classes
{
    public class Carrinho : ICarrinho
    {
        Produto produto = new Produto();
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto novoProduto) {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco= produto.Preco;
        }
        public void Cadastrar(Produto produto) {
            carrinho.Add(produto);
         }
        public void Listar(){
            foreach(Produto item in carrinho) {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Preco);
            }
         }
        public void Deletar(int cod) {
            Produto prodDelete = carrinho.Find(x => x.Codigo == cod);

            if(prodDelete != null) {
                carrinho.Remove(prodDelete);
            }
        }

        public void Deletar(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}