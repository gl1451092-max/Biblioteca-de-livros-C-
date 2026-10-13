using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LivroModel
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        public LivroModel(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}";
        }
    }
}