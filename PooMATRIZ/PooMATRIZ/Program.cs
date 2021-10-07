using System;

namespace PooMATRIZ
{
    
        
        class Program
        {
            static void Main(string[] args)

            {
                Console.WriteLine("Digite A grandeza da Matriz :");
                
                //input dos valores da matriz
                int n = int.Parse(Console.ReadLine());
                int[,] mat = new int[n, n];
                Console.WriteLine("Digite os valores da matriz separando por espacos cada valor :");
                
                //Loop da matriz
                for (int i = 0; i < n; i++)
                {
                    string[] values = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        mat[i, j] = int.Parse(values[i]);
                    }
                }
                
                //Valores da diagonal principal e Output de dados
                Console.WriteLine("Diagonal Principal:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(mat[i, i] + " ");
                }
                Console.WriteLine();
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mat[i, j] < 0)
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine("Numeros Negativos: " + count);
            }
        }
    }

        