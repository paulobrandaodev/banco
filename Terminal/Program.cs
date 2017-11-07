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
            
            Console.WriteLine(contapf.Sacar(500.00));
                       

        }
    }
}
