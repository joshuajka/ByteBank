using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public static double TaxaOperacao  { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                ArgumentException e = new ArgumentException("A agência não pode ter valor menor ou igual a zero.",nameof(agencia));
                throw e;
            }
            if (numero <= 0)
            {
                ArgumentException e = new ArgumentException("A conta não pode ter valor menor ou igual a zero.", nameof(numero));
                throw e;
            }

            NumeroAgencia = agencia;
            NumeroConta = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

            //try
            //{
            //    TotalDeContasCriadas++;
            //    TaxaOperacao = 30 / TotalDeContasCriadas;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Não é possível fazer uma divisão por zero");
            //}
        }

        private double _saldo = 100.5;
        //private Cliente _cliente;
        private Cliente _cliente = new Cliente();

        
        public Cliente Cliente { 
            get => _cliente; 
            set => _cliente = value; 
        }

        public int NumeroAgencia { get; }

        public int NumeroConta { get; }

        public double Saldo {
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
            if (this._saldo >= valor)
            {
                this._saldo = this._saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor >= 0)
            {
                this._saldo = this._saldo + valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor,ContaCorrente c2)
        {
            if (this._saldo >= valor)
            {
                c2.Saldo = c2.Saldo + valor;
                this._saldo = this._saldo - valor;
                return true; 
            }
            else
            {
                return false;
            }
        }

    }
}
