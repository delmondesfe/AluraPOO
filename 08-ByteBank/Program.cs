using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cli = new Cliente();
            cli.Nome = "Felipe";
            cli.Cpf = "45401384807";
            cli.Profissao = "Analista de sistemas";

            Cliente cli2 = new Cliente();
            cli2.Nome = "Luis";
            cli2.Cpf = "45401384807";
            cli2.Profissao = "Analista de sistemas";




            ContaCorrente cc = new ContaCorrente(cli, 862, 10101012);
            ContaCorrente cc2 = new ContaCorrente(cli2, 862, 10101013);


            


            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();

            

        }
    }
}
