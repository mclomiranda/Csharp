using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcao = OpcaoUsuario();
            Aluno[] alunos = new Aluno[5];
            var IndiceAluno = 0;

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Insira o nome do aluno:");
                        
                        var aluno = new Aluno();   
                        
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Insira a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(),out decimal nota))
                        {                
                            aluno.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentException("Valor inválido");
                        }

                        alunos[IndiceAluno] = aluno;

                        IndiceAluno++;

                        break;

                    case "2":
                        


                    break;

                    case "3":
                        Console.WriteLine("média");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

              opcao = OpcaoUsuario();

            }

        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1- para inserir um novo usuário");
            Console.WriteLine("2- para lista usuário");
            Console.WriteLine("3- para calcular média geral");
            Console.WriteLine("X  para sair");
            Console.WriteLine();

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}
