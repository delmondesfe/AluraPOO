using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente felipe = new Cliente();

            felipe.nome = "Luis Felipe";
            felipe.cpf = "45401384807";
            felipe.profissao = "An Sistemas";


            ContaCorrente contaFelipe = new ContaCorrente();

            contaFelipe.titular.nome = "Felipe";

          

        }
    }
}
