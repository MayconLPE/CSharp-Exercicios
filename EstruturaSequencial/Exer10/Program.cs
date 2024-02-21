internal class Program
{
    private static void Main(string[] args)
    {
        // Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Farenheit. F = (9 * C + 160) / 5

        double GrausC, GrausF;    
        Console.WriteLine("Digite a Temperatura em Graus Celsius:");
        GrausC = double.Parse(Console.ReadLine());
        Console.WriteLine(GrausC);
        GrausF = (9 * GrausC + 160) / 5;
       
        Console.WriteLine("A temperatura " + GrausC + "°F convertido \nem graus Celsius é: " + GrausF);
    }
}