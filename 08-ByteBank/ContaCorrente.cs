namespace _08_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }


        private double _saldo = 100;

        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                
                if (value < 0)
                {
                    return;
                }
                _saldo = value;

            }
        }


        public bool Sacar(double valor)
        {
            if(_saldo > valor)
            {
                this._saldo -= valor;
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
          
            if(_saldo > valor)
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }



        public static int TotalDeContasCriadas { get; private set; }
       
    }
}