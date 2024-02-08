internal class Program
{
    private static void Main(string[] args)
    {
        // 4. Faça um Programa que peça as 4 notas bimestrais e mostre a média.
        double soma = 0;
        double media = 0;

        for (int i = 1; i < 5; i++) {
            Console.WriteLine("digite a " + i + "° nota:");
            double nota = double.Parse(Console.ReadLine());
            soma = soma + nota;
        }

        media = soma / 4;

        Console.WriteLine("A média das notas é: " + media);

        
    }
}