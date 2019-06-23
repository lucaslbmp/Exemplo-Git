using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Salario do funcionario: ");
            f.salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.imposto = double.Parse(Console.ReadLine());
            Console.Write("\n"+f);
            Console.Write("\nPercentual de aumento: ");
            double porcent = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcent);
            Console.Write("\n"+f);
            Console.ReadLine();
        }
    }
}
