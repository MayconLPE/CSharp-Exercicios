internal class Program
{
    private static void Main(string[] args)
    {
        /*17. Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada.
        Considere que a cobertura da tinta é de 1 litro para cada 6 metros quadrados e que a tinta é vendida em latas de 18 litros, que
        custam R$ 80,00 ou em galões de 3,6 litros, que custam R$ 25,00.
        informe ao usuário as quantidades de tinta a serem compradas e os respectivos preços em 3 situações:
        comprar apenas latas de 18 litros;
        comprar apenas galões de 3,6 litros;
        misturar latas e galões, de forma que o preço seja o menor. Acrescente 10% de folga e sempre arredonde os valores
        para cima, isto é, considere latas cheias
        */
        Console.WriteLine("Medidas de metros a serem pintadas: ");
        double medida = double.Parse(Console.ReadLine());
        double litros = medida / 6; // Quantidade de tinta para pintar parede.
        double latas = litros / 18; // Math.ceil Arredondamento.
        double galoes = litros / 3.6;
        double precoLatas = latas * 80;
        double precoGaloes = galoes * 25;
        double combinacao = (litros / 18) * 80 + ((litros % 18)/3.6) * 25;

        Console.WriteLine("O preço só com latas é: R$ " + precoLatas.ToString("F"));
        Console.WriteLine("O preço só com galões é: R$ " + precoGaloes.ToString("F"));
        Console.WriteLine("O preço combinado é: R$ " + combinacao.ToString("F"));
    }
}