using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeAluno = 16;
            int quantidadePessoas = 2;

            if (idadeAluno >= 18)
            {
                Console.WriteLine("Aluno possui mais de 18 anos de idade.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Aluno não possui mais de 18 anos mas está acompanhado");
                }
                else
                {
                    Console.WriteLine("Aluno não possui mais de 18 anos.");
                }                
            }

            Console.ReadLine();
        }
    }
}
