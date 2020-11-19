using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMPORTANTE!
            // Olhe o codigo até o final.

            // Primeiro veja essa passado em aula.
            // Depois comite ele e descomite o próximo q eu fiz.
            // E teste.
            
            
            
            // Codigo passado em aula.
            // --------------------------------------------------------
            string[] produtos = {"maça", "batata", "cenoura"};
            double[] precos = {1.1, 2.3, 4.5};
            int[] idades = {16, 17, 17};

            string[] nomesAlunos = new string[5];

            // Mostra os produtos
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(produtos[i]);
                
            }Console.WriteLine("----------------------------");

            // Mostra dos preços
            for (int i = 0; i < precos.Length; i++)
            {
                Console.WriteLine(precos[i]);
                
            }Console.WriteLine("----------------------------");

            // Mostra as idades
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine(idades[i]);
                
            }Console.WriteLine("----------------------------");



            // Codigo que eu fiz.
            // Ele pede os produtos que você quer.
            // Depois mostra os preços.
            // --------------------------------------------------------------------------------


            // string[] produtos = {"maça", "batata", "cenoura", "manga", "abacate", "banana"};
            // double[] precos = {1.1, 2.3, 4.5, 3.2, 2.4, 3.8};

            // string[] quaisProdutos = new string[3];

            // for (int i = 0; i < quaisProdutos.Length; i++)
            // {
            //     Console.Write("Digite o produto: ");
            //     quaisProdutos[i] = Console.ReadLine();
            // }

            // for (int i = 0; i < quaisProdutos.Length; i++)
            // {
            //     Console.WriteLine("----------------");
            //     Console.WriteLine(quaisProdutos[i]);
            //     Console.Write("Preço: ");
            //     Console.WriteLine(precos[i]);
            // }
        }
    }
}
