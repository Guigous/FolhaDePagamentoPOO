using System;
using System.Collections.Generic;

namespace FolhaPagamentos
{
    class Program
    {
        
        static void Main(string[] args)
        {//instaciamento da lista
            List<Funcionarios> funcionarios = new List<Funcionarios>();
            Console.WriteLine("FOLHA DE PAGAMENTO------------------ ");
            Console.WriteLine();
            Console.WriteLine("Numero de Funcionarios a serem Listados: ");
            Console.WriteLine();

            //numero indicado pelo usuario
            int n = int.Parse(Console.ReadLine());
            //loop para input de dados
            for( int i=0; i<n; i++ )
            {
                Console.WriteLine("Digite (s) para Simples e (t) Para Tercerizado");
                char resposta =char.Parse(Console.ReadLine());
                //condicional
                if (resposta == 's')
                {
                    Console.WriteLine("Nome Do Funcionario: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Horas Trabalhadas: ");
                    double horasTrabalhadas = double.Parse(Console.ReadLine());

                    Console.WriteLine("Valor da Hora: ");
                    double valorPorHora = double.Parse(Console.ReadLine());
                    
                    funcionarios.Add(new Funcionarios (nome, horasTrabalhadas, valorPorHora ));

                    double salarios = funcionarios[i].CalcSalario();


                }
                //condicional
                if(resposta == 't')
                {
                    

                    Console.WriteLine("Nome Do Funcionario: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Horas Trabalhadas: ");
                    double horasTrabalhadas = double.Parse(Console.ReadLine());

                    Console.WriteLine("Valor da Hora: ");
                    double valorPorHora = double.Parse(Console.ReadLine());

                    Console.WriteLine("Despesas: ");
                    double despesa = double.Parse(Console.ReadLine());


                    funcionarios.Add(new Tercerizado (nome, horasTrabalhadas, valorPorHora, despesa ));

                    
                }
            }
            //output de dados
            foreach(Funcionarios funcionarios1 in funcionarios)
            {
                Console.WriteLine();
                Console.WriteLine("Nome: " + funcionarios1.Nome);
                Console.WriteLine("Horas Trabalhadas: " + funcionarios1.HorasTrabalhadas); 
                Console.WriteLine("Valor da Hora: " + funcionarios1.ValorPorHora);
                Console.WriteLine("Salario: " + funcionarios1.CalcSalario());
                Console.WriteLine();
            }
        }
    }
}
