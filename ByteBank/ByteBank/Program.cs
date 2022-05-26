using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario carlos = new Funcionario();
            Diretor roberta = new Diretor();

            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.457-20";
            carlos.Salario = 2000;

            roberta.Nome = "Roberta";
            roberta.CPF = "135.895.059-82";
            roberta.Salario = 5000;

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());

        }
    }
}