using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Felipe";
            conta.saldo = 1000;

            conta.Sacar(200);

            Console.WriteLine(conta.saldo);

            conta.Depositar(500);

            Console.WriteLine(conta.saldo);




            ContaCorrente contadaGrabriela = new ContaCorrente();

            contadaGrabriela.titular = "gabriela";
            conta.Transferir(100, contadaGrabriela);

            Console.WriteLine(contadaGrabriela.saldo);




            Console.ReadLine();
        }
    }
}
