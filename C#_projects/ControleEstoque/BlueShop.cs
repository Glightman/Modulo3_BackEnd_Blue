using System;
using System.Collections.Generic;

namespace ControleEstoque
{
    public class BlueShop
    {
        List<Produto> produtos = new List<Produto>();
        public void Iniciar()
        {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Cadastrar um produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("0 - Sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CadastroProduto();
                    break;
                case "2":
                    ListarProdutos();             
                    break;
                case "0":
                    return;              
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Iniciar();
        }
        void CadastroProduto()
        {
            Produto produto = new Produto();//AQUI EU ETOU INICIANDO UM NOVO OBJETO DO TIPO PRDUTO, QUE EU CRIEI EM OUTRO ARQUIVO. 
            Console.WriteLine("Informe um nome para o novo produto");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Informe um preço para o novo produto");
            produto.Preco = Convert.ToDouble(Console.ReadLine());
            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso!");
        }
        void ListarProdutos()
        {
            foreach (Produto p in produtos)
            {
                Console.WriteLine("--");
                Console.WriteLine(p.Descricao);
            }
        }

    }
}
