using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            ContaCorrente c2 = new ContaCorrente();
            //Cliente cl1 = new Cliente();
            //Cliente cl2 = new Cliente();
            //cl1.Nome = "Joao";
            //cl2.Nome = "Maria";

            conta.Cliente.Nome = "Joao";
            conta.NumeroAgencia = 863;
            conta.NumeroConta = 863452;

            c2.Cliente.Nome = "Maria";
            c2.NumeroAgencia = 864;
            c2.NumeroConta = 863453;
            //conta.Saldo = 1000.00;

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.Salario = 1000.00;
            carlos.CPF = "299.568.896-10";

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.Salario = 5000.00;
            roberta.CPF = "xxx.xxx.xxx-xx";

            GerenciadorBonificacao gr = new GerenciadorBonificacao();
            gr.Registrar(carlos);
            gr.Registrar(roberta); 


            Console.WriteLine($"Bonificão do {carlos.Nome} é de {carlos.GetBonificacao()}");

            Console.WriteLine($"Resumo da Diretora Nome: {roberta.Nome} Bonificacao: {roberta.GetBonificacao()} Salario: {roberta.Salario}");

            Console.WriteLine($"Total de bonificacão é de {gr.GetTotalBonificacao()}");

            Console.WriteLine($"Titular da conta corrente: {conta.Cliente.Nome}");
            Console.WriteLine($"Número da agência: {conta.NumeroAgencia}");
            Console.WriteLine($"Número da conta corrente: {conta.NumeroConta}");
            Console.WriteLine($"Saldo da conta corrente: {conta.Saldo}");

            if (conta.Sacar(59.25))
            {
                Console.WriteLine($"Saldo da conta corrente após o saque: {conta.Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque");
            }

            if(c2.Transferir(102, conta))
            {
                Console.WriteLine($"Saldo da conta corrente após depósito: {conta.Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferencia");
            }
            

            Console.WriteLine($"Saldo da conta de {c2.Cliente.Nome} é de R$ {c2.Saldo}");


            Console.ReadLine();


            
        }
    }
}
