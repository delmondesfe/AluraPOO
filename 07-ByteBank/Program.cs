using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente felipe = new Cliente();
            ContaCorrente conta = new ContaCorrente();

            felipe.Nome = "Felipe Delmondes";
            felipe.Cpf = "45401384807";
            felipe.Profissao = "An Sistemas";

            conta.Titular = felipe;
            conta.Numero = 101010;


            conta.Saldo = 1000;

            Console.WriteLine("Titular: " + conta.Titular.Nome);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Numero Conta: " + conta.Numero);
            Console.WriteLine("Saldo: " + conta.Saldo);





            Console.ReadLine();

        }
    }
}
