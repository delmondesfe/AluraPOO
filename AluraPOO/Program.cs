using System;

namespace AluraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoFelipe = new ContaCorrente();

            contaDoFelipe.titular = "Felipe Delmondes";
            contaDoFelipe.saldo = 1000;
            contaDoFelipe.numero = 101011;

            Console.WriteLine("titular: "+ contaDoFelipe.titular);
            Console.WriteLine("Agencia: "+ contaDoFelipe.agencia);
            Console.WriteLine("Numero da Conta: " + contaDoFelipe.numero);
            Console.WriteLine("Saldo: " + contaDoFelipe.saldo);

        }
    }
}


