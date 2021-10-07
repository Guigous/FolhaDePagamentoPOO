using System;
using System.Globalization;
using System.Linq;

namespace Alturas
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Numero de pessoas : ");
            int x= int.Parse(Console.ReadLine());
            double[] Doublearray = new double[x];
            
            
            for (int i=0;i<x;i++)

            {
                Console.WriteLine("Digite As Alturas : ");
                double n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
                Doublearray[i] = n;
            }
                       
            double a = Doublearray.Sum();
            Console.WriteLine(a/x);
            
        }
    }
}

