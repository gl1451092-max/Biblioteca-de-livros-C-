using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LivroController controller = new LivroController();
            LivroView view = new LivroView();
            int opcao;

            do
            {
                Tela.Menu();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        LivroModel novoLivro = view.LerDadosLivro();
                        controller.AdicionarLivro(novoLivro);
                        view.MostrarMensagem("Livro adicionado com sucesso!");
                        break;
                    case 2:
                        view.MostrarLivros(controller.ListarLivros());
                        break;
                    case 3:
                        string tituloBusca = view.LerTitulo();
                        LivroModel livroEncontrado = controller.BuscarPorTitulo(tituloBusca);
                        if (livroEncontrado != null)
                        {
                            view.MostrarMensagem($"Livro encontrado: {livroEncontrado}");
                        }
                        else
                        {
                            view.MostrarMensagem("Livro não encontrado.");
                        }
                        break;
                    case 4:
                        string tituloRemover = view.LerTitulo();
                        if (controller.RemoverLivro(tituloRemover))
                        {
                            view.MostrarMensagem("Livro removido com sucesso!");
                        }
                        else
                        {
                            view.MostrarMensagem("Livro não encontrado.");
                        }
                        break;
                    case 0:
                        view.MostrarMensagem("Saindo...");
                        break;
                    default:
                        view.MostrarMensagem("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}