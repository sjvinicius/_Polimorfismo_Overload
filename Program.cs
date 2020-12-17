using System;
using _Introducao_Polimorfismo_Overload.classes;

namespace _Introducao_Polimorfismo_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            // int qtdnome;
            int indice;
            string busca;
            char search;

            Funcionario f1 = new Funcionario();

            // Console.WriteLine("----     ---------------------------");
            // Console.Write("----     Qtd. de Nomes: ");
            // qtdnome = int.Parse( Console.ReadLine() );
            // Console.WriteLine("----     ---------------------------");
            
            // for (var i = 1; i <= qtdnome; i++)
            // {
                
            //     Console.Write($"----     Digite o {i}º nome:");
            //     f1.lista[i] = Console.ReadLine();

            // }

            Console.WriteLine("----     ---------------------------");
            Console.WriteLine("----     Como deseja fazer a visualizaçao do seu nome?");
            Console.WriteLine("----     [1] Ver todos os nomes");
            Console.WriteLine("----     [2] Consulta por ID");
            Console.WriteLine("----     [3] Consulta por Nome");
            Console.WriteLine("----     ---------------------------");


            search = char.Parse( Console.ReadLine() ); 

            switch (search)
            {
                case '1':

                    Console.WriteLine( f1.Mostrar() );

                    break;

                case '2':

                    Console.Write("----     Digite o ID: ");
                    indice = int.Parse( Console.ReadLine() );
                    Console.WriteLine("----     ---------------------------");

                    Console.WriteLine( f1.Mostrar(indice) );

                    break;

                case '3':
                    Console.WriteLine("----     ---------------------------");
                    Console.Write("----     Digite o Nome: ");
                    busca = Console.ReadLine();
                    Console.WriteLine("----     ---------------------------");


                    Console.WriteLine( f1.Mostrar(busca) );

                    break;


                default:

                    Console.WriteLine("----     ---------------------------");
                    Console.WriteLine("----     !!! Operação NÃO Válida !!!");
                    Console.WriteLine("----     ---------------------------");
                    break;
            }
            
            
        }
    }
}
