internal class Program
{
    private static void Main(string[] args)
    {
        /* Faça um Programa que peça 3 números inteiros e um número real. Calcule e mostre:
            o produto do dobro do primeiro com metade do segundo .
            a soma do triplo do primeiro com o terceiro.
            o terceiro elevado ao cubo. */

        int num1, num2, num3;

        Console.WriteLine("Digite o primeiro número inteiro: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número inteiro: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número inteiro: ");
        num3 = int.Parse(Console.ReadLine());

        double calculo1 = (num1 * 2) + (num2/2);
        Console.WriteLine("o produto do dobro do primeiro com metade do segundo: \n" + calculo1);

        double calculo2 = (num1 * 3) + num3;
        Console.WriteLine("soma do triplo do primeiro com o terceiro: \n "+ calculo2);

        double calculo3 = num3 *  num3 * num3;
        Console.WriteLine("O terceiro elevado ao cubo: \n" + calculo3);

    }
}