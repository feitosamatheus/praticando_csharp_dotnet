using System;

namespace trabalhando_csharp_dotnet.metodos
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            Metodos meto = new Metodos();

            string opcaoUsuario = obterRespostaUsuario();
            var indexAluno = 0;

            while (opcaoUsuario.ToUpper () != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":

                        alunos[indexAluno] = meto.AdicionaItemArray(alunos, indexAluno);
                        indexAluno++;

                        break;
                    case "2":

                        meto.pecorrendoArray(alunos);
                       
                        break;
                    case "3":

                        meto.retornaMedia(alunos);

                        break;
                    default:
                            throw new ArgumentOutOfRangeException("FORMATO INVALIDO");
                }

                opcaoUsuario = obterRespostaUsuario();
            }
        }
        public static string obterRespostaUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informa opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opçaoDesejada = Console.ReadLine();

            return opçaoDesejada;
        }
    }
}
