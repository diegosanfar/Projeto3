using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.autor = autor;
            this.preco = preco;
            this.nome = nome;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada no estoque de um ebook digital.");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no Ebook {nome}");
            Console.WriteLine("Digite a quantidade de vendas: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas += entrada;
            Console.WriteLine("Saída registrada.");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("=============================");
        }
    }
}
