using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    [System.Serializable]
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no curso {nome}");
            Console.WriteLine("Digite a quantidade de vagas: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada.");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Consumir vagas do curso {nome}");
            Console.WriteLine("Digite a quantidade de vagas: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas -= entrada;
            Console.WriteLine("Saída registrada.");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("=============================");
        }
    }
}
