internal class Program
{
    private static void Main(string[] args)
    {
        /* 15. Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total
            do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o
            sindicato, faça um programa que nos dê:
            salário bruto.
            quanto pagou ao INSS.
            quanto pagou ao sindicato.
            o salário líquido.
            calcule os descontos e o salário líquido, conforme a tabela abaixo:
            + Salário Bruto : R$
            - IR (11%) : R$
            - INSS (8%) : R$
            - Sindicato ( 5%) : R$
            = Salário Liquido : R$
            Obs.: Salário Bruto - Descontos = Salário Líquido */

        
        Console.WriteLine("Quanto você ganha por hora?");
		double salarioHora = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Número de horas trabalhadas no mês?");
		double horaTrabalho = double.Parse(Console.ReadLine());
		
		double salarioBruto = salarioHora * horaTrabalho;
		Console.WriteLine("O salário referido a este mês é de: R$ " + salarioBruto); //Salario Bruto
		
		double impostoRenda = (salarioBruto / 100) * 11; //IR de 11%
		Console.WriteLine("IR (11%) : R$ " + impostoRenda);
		
		double Inss = (salarioBruto / 100)  * 8; // INSS de 8%
		Console.WriteLine("INSS (8%) : R$: " + Inss);
		
		double Sindicato = (salarioBruto / 100)  * 5; //Sindicato 5%
		Console.WriteLine("Sindicato (5%) : R$: " + Sindicato);
		
		double descontos = impostoRenda + Inss + Sindicato; // soma de todos os descontos 
		double salarioLiquido = salarioBruto - descontos; //total Salário Liquido
		
		Console.WriteLine("Salário Liquido: " + salarioLiquido);	
    }
}