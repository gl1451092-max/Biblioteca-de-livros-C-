using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LivroController
    {
        private List<LivroModel> livros = new List<LivroModel>();

        public void AdicionarLivro(LivroModel livro)
        {
            livros.Add(livro);
        }

        public List<LivroModel> ListarLivros()
        {
            return livros;
        }

        public LivroModel BuscarPorTitulo(string titulo)
        {
            return livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        public bool RemoverLivro(string titulo)
        {
            LivroModel livro = BuscarPorTitulo(titulo);
            if (livro != null)
            {
                livros.Remove(livro);
                return true;
            }
            return false;
        }
    }
}