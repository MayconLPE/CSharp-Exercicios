internal class Program
{
    private static void Main(string[] args)
    {
        /* 18. Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um link de Internet (em Mbps),
        calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos)*/

        Console.WriteLine("Digite o tamanho do arquivo:");
        double tamArquivo = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a velocidade da internet:");
        double velInternet = double.Parse(Console.ReadLine());
        double tempo = tamArquivo / velInternet;

        Console.WriteLine("Tempo de Download " + tempo);
    }
}