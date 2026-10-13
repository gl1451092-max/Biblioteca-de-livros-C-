using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class BookModel
    {
        //
        // ATRIBUTOS / PROPRIEDADES
        //
        private string _isbn;
        private string _title;
        private string _author;
        private string _genre;
        private int _pages;
        private bool _borrowed;

        //
        // propriedades
        //
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value > 0)
                {
                    _pages = value;
                }
            }
        }

        public bool Borrowed
        {
            get { return _borrowed; }
            set { _borrowed = value; }
        }

        //
        // MÉTODO CONSTRUTOR COM DADOS
        //
        public BookModel(string cod, string tit, string aut, string gen, int pag)
        {
            this.Isbn = cod;
            this.Title = tit;
            this.Author = aut;
            this.Genre = gen;
            this.Pages = pag;
            this.Borrowed = false;
        }

        //
        // MÉTODO CONSTRUTOR SEM DADOS
        //
        public BookModel()
        {
            this.Isbn = "";
            this.Title = "";
            this.Author = "";
            this.Genre = "";
            this.Pages = 0;
            this.Borrowed = false;
        }
    }
}