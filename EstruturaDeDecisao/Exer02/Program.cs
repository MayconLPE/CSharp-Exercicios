internal class Program
{
    private static void Main(string[] args)
    {
        // 2. Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.

        double num;

        Console.WriteLine("Digite um número: ");
        num = double.Parse(Console.ReadLine());

        if (num < 0) 
        {
            Console.WriteLine(num + " é um múmero negativo");
            
        }
        else if (num > 0)
        {
            Console.WriteLine(num + " é um número positivo");
        }
        else
        {
            Console.WriteLine(num + " é um número neutro");
        }
    }
}