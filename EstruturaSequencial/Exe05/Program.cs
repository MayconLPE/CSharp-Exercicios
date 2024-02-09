internal class Program
{
    private static void Main(string[] args)
    {
        // 5. Faça um Programa que converta metros para centímetros. cm = m * 100

        double metros, centimetros;

        Console.WriteLine("Digite os metros: ");
        metros = double.Parse(Console.ReadLine());
        centimetros = metros * 100;

        Console.WriteLine(metros + " metros é igual a: " + centimetros + " Centímetros.");
    }
}