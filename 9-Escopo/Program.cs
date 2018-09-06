using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeAluno = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Alun o está acompanhado";
            }
            else
            {
                mensagemAdicional = "Aluno não está acompanhado";
            }

            if (idadeAluno >= 18 && acompanhado == true)
            {
                Console.WriteLine("Acesso ao local permitido");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Acesso ao local negado");
            }

            Console.ReadLine();
        }
    }
}
