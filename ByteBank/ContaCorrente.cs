using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        private double _saldo = 100.5;
        //private Cliente _cliente;
        private Cliente _cliente = new Cliente();
        
        public Cliente Cliente { 
            get => _cliente; 
            set=> _cliente = value; 
        }

        public int NumeroAgencia { get; set; }

        public int NumeroConta { get; set; }

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
