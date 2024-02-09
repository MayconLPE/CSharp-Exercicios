internal class Program
{
    private static void Main(string[] args)
    {
        // 6. Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
        double raioCirculo, areaCirculo;

        Console.WriteLine("Digite o raio do círculo: ");
        raioCirculo = double.Parse(Console.ReadLine());

        areaCirculo = Math.PI * Math.Pow(raioCirculo, 2);
        Console.WriteLine(" A área do círculo de raio " +  raioCirculo.ToString() + " é : " + areaCirculo.ToString());

    }
}