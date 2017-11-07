using System;
using Dados;
using Util;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {   

            ContaPessoaFisica contapf = new ContaPessoaFisica();
            Console.WriteLine(contapf.Depositar(380.00));

            Console.WriteLine(contapf.Sacar(180.00));

            ContaPessoaJuridica contapj = new ContaPessoaJuridica();
            Console.WriteLine(contapj.Depositar(500.00));  

            Console.WriteLine(contapj.Sacar(280.00));                       

        }
    }
}
