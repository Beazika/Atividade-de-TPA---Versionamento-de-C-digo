using System;
namespace Atividade_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=0;
            string[] chamada;
            chamada = new string[10];
            string[] presenca;
            presenca = new string[10];
            string[] nomes;
            
                nomes = new string[10] {"[ 01 ] Antony S.", "[ 02 ] Bruce B.", "[ 03 ] Clint B.", "[ 04 ] Gamora Z.", "[ 05 ] Michele J.", "[ 06 ] Natasha R.", "[ 07 ] Nebulosa Z.", "[ 08 ] Peter P.", "[ 09 ] Stephen S.", "[ 10 ] Wanda M."};
                Console.WriteLine("\nMenu de registro");
                Console.WriteLine("[ 1 ] Registrar presença\n[ 2 ] Consultar presença\n[ 3 ] Lista de alunos\n[ 0 ] Sair");
                Console.Write("Escolha a opção desejada: ");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                
        }
    }
}
