internal class Program
{
    private static void Main(string[] args)
    {
        // 3. Faça um Programa que peça dois números e imprima a soma.

        double num1, num2, soma;

        Console.WriteLine("Digite um número: ");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        num2 = double.Parse(Console.ReadLine());

        soma = num1 + num2;

        Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a: " + soma);


    }
}