using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        float valorHora, salario;
        int numeroHorasTrabalhadas;
        float idFuncionario;
        Console.Write("Digite o id do funcionario:");
        idFuncionario = float.Parse(Console.ReadLine());
        Console.Write("Digite o valor da hora trabalhada: ");
        valorHora= float.Parse(Console.ReadLine());
        Console.Write("Digite as horas trabalhadas ao mês: ");
        
        
        numeroHorasTrabalhadas = int.Parse(Console.ReadLine());
        salario = valorHora * numeroHorasTrabalhadas;
        Console.WriteLine("Numero de identificação(id) do funcionario:{0}", +idFuncionario);
       
        Console.WriteLine("O valor do salário bruto foi de:{0}", Convert.ToDecimal(salario).ToString("f2", CultureInfo.InvariantCulture));
       
        Console.ReadLine();
      
    }
}




