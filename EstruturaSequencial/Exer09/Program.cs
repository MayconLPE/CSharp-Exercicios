internal class Program
{
    private static void Main(string[] args)
    {
        // Faça um Programa que peça a temperatura em graus Farenheit, transforme e mostre a temperatura em graus Celsius. C = (5 * (F-32) / 9).
        double grausF, grausC;

        Console.WriteLine("Digite a temperatura em graus Farenheit: ");
        grausF = double.Parse(Console.ReadLine());

        grausC = (5 * (grausF - 32)/9);

        Console.WriteLine("Graus Celsius: " + grausC.ToString("F"));
    }
}