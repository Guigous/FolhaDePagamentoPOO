using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamentos
{
    public class Funcionarios
    {//encapsulamento
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }
        //construtor
        public Funcionarios(string nome, double horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

        //metodo de calculo do salario
        public virtual double CalcSalario()
        {
            double salario = HorasTrabalhadas * ValorPorHora;
            return salario;
        }

        
    }




    public class Tercerizado : Funcionarios
    {
        //encapsulamento
        public double Despesa { get; set; }

       

        //construtor
        public Tercerizado(string nome, double horasTrabalhadas, double valorPorHora, double despesa)
            : base(nome, horasTrabalhadas, valorPorHora)
        {
            Despesa = despesa;
        }

        
        //metodo do calculo do tercerizado
        public override double CalcSalario()
        {
            
            double salarioterc = (HorasTrabalhadas*ValorPorHora)+Despesa*1.1;
            return salarioterc;

        }
    }

  
            

       
    
}
