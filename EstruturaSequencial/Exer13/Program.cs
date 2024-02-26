internal class Program
{
    private static void Main(string[] args)
    {
        /* Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
            Para homens: (72.7*h) - 58
            Para mulheres: (62.1*h) - 44.7 */

        double altura, pesoIdeal;
        int selecao;
    
        Console.WriteLine("Digite sua altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Selecione a opção 1 - Homem ou 2- Mulher");
        selecao = int.Parse(Console.ReadLine());

        switch (selecao)
        {
            case 1:
            pesoIdeal = (72.7*altura) - 58;
            Console.WriteLine("Homem: " + pesoIdeal);
            break;

            case 2:
            pesoIdeal = (62.1*altura) - 44.7;
            Console.WriteLine("Mulher: " + pesoIdeal);
            break;    

            default:
            Console.WriteLine("Opção invalida!");
            break;
        }
        pesoIdeal = (72.7*altura) - 58;

    }
}