internal class Program
{
    private static void Main(string[] args)
    {
        // 2) Faça um programa que receba dois números e ao final mostre 
        // a soma, subtração, multiplicação e a divisão dos números lidos.

        int soma, sub, mult;
        float div;

        int num1=10;
        int num2=2;

        soma=num1+num2;
        sub=num1-num2;
        mult=num1*num2;
        div=num1/num2;
        
        Console.WriteLine("A soma = " + soma);
        Console.WriteLine("A subtração = " + sub);
        Console.WriteLine("A multiplicação = " + mult);
        Console.WriteLine("A divisão = " + div);
    }
}