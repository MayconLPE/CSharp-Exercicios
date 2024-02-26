internal class Program
{
    private static void Main(string[] args)
    {
        // 12. Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, 
        // usando a seguinte fórmula: (72.7*altura) - 5812.

        double altura, pesoIdeal;
    
        Console.WriteLine("Digite sua altura: ");
        altura = double.Parse(Console.ReadLine());
        pesoIdeal = (72.7*altura) - 58;

        Console.WriteLine("Seu peso ideal = " + pesoIdeal);
    }
}