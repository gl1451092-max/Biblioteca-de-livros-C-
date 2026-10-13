using System;

namespace Biblioteca
{
    internal class Tela
    {
        public static void Menu()
        {
            Console.Clear();

            // Configura cor da moldura
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.Write("║");

            // Texto do Título em outra cor
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("          MENU BIBLIOTECA               ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║");
            Console.WriteLine("╠════════════════════════════════════════╣");

            // Opções do Menu
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║  1. Adicionar Livro                   ║");
            Console.WriteLine("║  2. Listar Livros                     ║");
            Console.WriteLine("║  3. Buscar Livro por Título           ║");
            Console.WriteLine("║  4. Remover Livro                     ║");
            Console.WriteLine("║  0. Sair                              ║");

            // Fechamento da moldura
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚════════════════════════════════════════╝");

            // Prompt de escolha
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEscolha uma opção: ");

            // Reseta a cor padrão do console
            Console.ResetColor();
        }
    }
}