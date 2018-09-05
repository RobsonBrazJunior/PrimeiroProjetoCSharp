using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Curso de conceitos básicos de C# " + 2018;
            //A utilização do @ permite criar uma string com várias linhas, conforme a seguir:
            string cursosProgramacao = @" - .NET
                - Java
                - JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            string vazia = "";

            Console.ReadLine();
        }
    }
}
