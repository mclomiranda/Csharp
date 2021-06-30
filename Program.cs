using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite uma opção:");
           Console.WriteLine("1- para inserir um novo usuário");
           Console.WriteLine("2- para lista usuário");
           Console.WriteLine("3- para calcular média geral");
           Console.WriteLine("X  para sair");
           Console.WriteLine();

            string opcao = Console.ReadLine ();

            while(opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                case "1":
                    Console.WriteLine("aluno");
                    break;
                
                case "2":   
                      Console.WriteLine("lista");
                    break;

                case "3":
                    Console.WriteLine("média");
                    break;

                default:
                throw new ArgumentOutOfRangeException ();
                }

                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1- para inserir um novo usuário");
                Console.WriteLine("2- para lista usuário");
                Console.WriteLine("3- para calcular média geral");
                Console.WriteLine("X  para sair");
                Console.WriteLine();

                opcao = Console.ReadLine ();

            }
                   
        
        }


    }
}
