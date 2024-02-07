internal class Program
{
    private static void Main(string[] args)
    {
        /* 7) Faça um programa que leia uma temperatura em graus Celsius e apresente-a
            convertida em graus Fahrenheit. A fórmula de conversão é: F = (9 * C + 160) / 5, na qual
            F é a temperatura em Fahrenheit e C é a temperatura em Celsius; */

        double GrausC, GrausF;    
        Console.WriteLine("Digite a Temperatura em Graus Celsius:");
        GrausC = double.Parse(Console.ReadLine());

        Console.WriteLine(GrausC);

        GrausF = (9 * GrausC + 160) / 5;
       
        Console.WriteLine("A temperatura " + GrausC + "°F convertido \nem graus Celsius é: " + GrausF);
    }
}