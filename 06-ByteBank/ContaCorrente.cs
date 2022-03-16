namespace _06_ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular;
        public int agencia = 863;
        public int numero;
        private double saldo = 100;




        public bool Sacar(double valor)
        {
            if(saldo > valor)
            {
                this.saldo -= valor;
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
          
            if(saldo > valor)
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ObterSaldo()
        {
            return this.saldo;
        }

        public void DefinirSaldo(double saldo)
        {
            if(saldo > 0)
            {
                this.saldo += saldo;
            }
            else
            {
                
            }
        }


    }
}