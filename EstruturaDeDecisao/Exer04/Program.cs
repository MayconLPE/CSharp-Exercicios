internal class Program
{
    private static void Main(string[] args)
    {
        // 4. Faça um Programa que verifique se uma letra digitada é vogal ou consoante.
        Console.Write("Digite uma letra: ");
        char letra = Console.ReadKey().KeyChar;

        if (char.IsLetter(letra))
        {
            if (IsVogal(letra))
                Console.WriteLine("\nÉ uma vogal.");
            else
                Console.WriteLine("\nÉ uma consoante.");
        }
        else
        {
            Console.WriteLine("\nNão é uma letra válida.");
        }
    }

    static bool IsVogal(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }

}
