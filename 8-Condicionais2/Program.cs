using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeAluno = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            Console.WriteLine(acompanhado);

            if (idadeAluno >= 18 || acompanhado)
            {
                Console.WriteLine("Acesso ao local permitido");
            }
            else
            {
                Console.WriteLine("Acessoao local negado");
            }

            Console.ReadLine();
        }
    }
}
