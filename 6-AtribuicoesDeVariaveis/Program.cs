﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuições de Variáveis");

            int idade = 32;
            int idadeAluno = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeAluno);

            Console.ReadLine();
        }
    }
}
