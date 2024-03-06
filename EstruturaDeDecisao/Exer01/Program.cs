internal class Program
{
    private static void Main(string[] args)
    {
        // Faça um Programa que peça dois números e imprima o maior deles.
        int num1, num2;

        Console.WriteLine("Digite o primeiro numero:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2) {
            Console.WriteLine(num1 + " é maior que " + num2);
        } 
        else if ( num2 > num1) {
            Console.WriteLine(num2 + " é maior que " + num1);
        } 
        else {
            Console.WriteLine("São iguais!");
        }
    }
}