using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LivroView
    {
        public LivroModel LerDadosLivro()
        {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();

            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());

            return new LivroModel(titulo, autor, ano);
        }

        public void MostrarLivros(List<LivroModel> livros)
        {
            Console.WriteLine("\n--- Lista de Livros ---");
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
            }
            else
            {
                foreach (var livro in livros)
                {
                    Console.WriteLine(livro);
                }
            }
        }

        public void MostrarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public string LerTitulo()
        {
            Console.Write("Digite o título do livro: ");
            return Console.ReadLine();
        }
    }
}