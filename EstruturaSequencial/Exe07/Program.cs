internal class Program
{
    private static void Main(string[] args)
    {
       {
        // 7. Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.
        double lado, area;

        Console.WriteLine("Digite o lado do Quadrado:");
        lado = double.Parse(Console.ReadLine());

        area = Math.Pow(lado, 2);
        Console.WriteLine("Área do quadrado é: " + area);
        Console.WriteLine("Dobro da área do quadrado: " + (area * 2));


        }
    }
}