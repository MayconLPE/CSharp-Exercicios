internal class Program
{
    private static void Main(string[] args)
    {
        // 4) Escrever um programa que leia o nome de um vendedor, o seu salário fixo e o
        // total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor
        // ganha 15% de comissão sobre suas vendas efetuadas, informar o seu nome, o salário
        // fixo e salário no final do mês.

        String nomeVendedor = "Maycon";
        double salarioFixo = 5000;
        double totalVendas = 2000;
        double comissao = (totalVendas/100)*15; // 15%
        double salarioFinal = salarioFixo+comissao;
    
        Console.WriteLine("Nome: " + nomeVendedor);
        Console.WriteLine("Salario fixo: " + salarioFixo);
        Console.WriteLine("Salario final: " + salarioFinal);
    }
}