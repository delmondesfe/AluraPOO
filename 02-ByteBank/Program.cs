﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Felipe";

            Console.WriteLine("Titular: "+ conta.titular);
            Console.WriteLine("Agencia: " + conta.agencia);
            Console.WriteLine("Saldo: "+ conta.saldo);


            Console.ReadLine();
        }
    }
}
