using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //Console.ReadLine();

            //CalcularBonificacao();

            SistemaInterno();

            Console.ReadLine();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer d = new Designer("888.888.888-88");
            d.Nome = "Pedro";

            Diretor d1 = new Diretor(5000, "999.999.999-99");
            d1.Nome = "Roberta";

            Auxiliar au = new Auxiliar("111.111.111-11");
            au.Nome = "Estagiario";

            GerenteDeConta gc = new GerenteDeConta("222.222.222-22");
            gc.Nome = "Camila";

            Desenvolvedor dev = new Desenvolvedor("XXX.XXX.XXX-XX");

            gerenciadorBonificacao.Registrar(dev);
            gerenciadorBonificacao.Registrar(d);
            gerenciadorBonificacao.Registrar(d1);
            gerenciadorBonificacao.Registrar(au);
            gerenciadorBonificacao.Registrar(gc);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());

        }

        public static void SistemaInterno()
        {
            SistemaInterno si = new SistemaInterno();
            Diretor d1 = new Diretor(5000, "999.999.999-99");
            d1.Nome = "Roberta";
            d1.DefinirSenha("123");
            si.Logar(d1, "13");
        }

    }
}
