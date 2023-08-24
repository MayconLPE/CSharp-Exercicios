internal class Program
{
    private static void Main(string[] args)
    {
        // 5) Escrever um programa que leia o nome de um aluno e as notas das três provas
        // que ele obteve no semestre. No final informar o nome do aluno e a sua média (aritmética).

        string nome="";
        double nota1,nota2,nota3,media;

        Console.WriteLine("Digite o nome do aluno: ");
        nome=Console.ReadLine();
        Console.WriteLine("Digite a primeira nota: ");
        nota1=double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2=double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota: ");
        nota3=double.Parse(Console.ReadLine());

        media=(nota1+nota2+nota3)/3;
        Console.WriteLine("Aluno: " + nome + " - Media: " + media);
    }
}