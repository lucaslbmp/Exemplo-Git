using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public double imposto;

        public double SalarioLiquido()
        {
            return salario - imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            salario = (1 + porcentagem/100.0) * salario;
            return salario;
        }


        public override string ToString()
        {
            return "Funcionario: " + nome + ", $" + SalarioLiquido();
        }
    }
}
