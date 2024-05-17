internal class Program
{
    private static void Main(string[] args)
    {
        /* 3. Faça um Programa que verifique se uma letra digitada é "F" ou "M". 
        Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido. */
        const int MaxTamanhoString = 1;
        Console.WriteLine("Digite F para Feminino ou M para Masculino");
        string letra = Console.ReadLine();

        if (letra == "f" || letra == "F")
        {
            Console.WriteLine("Feminino");
        }
        else if (letra == "m" || letra == "M")
        {
            Console.WriteLine("Masculino");
        }
        else
        {
            Console.WriteLine("Character incorreto");
        }
    }
}