internal class Program
{
    private static void Main(string[] args)
    {
        /* 8. Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. 
        Calcule e mostre o total do seu salário no referido mês. */

        double salarioHoras, horasTrabalhadas, salarioTotal;

        Console.WriteLine("Quanto você ganha por hora?");
        salarioHoras = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite as horas trabalhadas:");
        horasTrabalhadas = double.Parse(Console.ReadLine());
        salarioTotal = salarioHoras * horasTrabalhadas;

        Console.WriteLine("Salario total ganho por mês: R$ " + salarioTotal);


        
    }
}