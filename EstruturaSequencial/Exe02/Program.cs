internal class Program
{
    private static void Main(string[] args)
    {
        // 2. Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].

        Console.WriteLine("Digite um número: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("O número digitado foi: " + number);
        
    }
}