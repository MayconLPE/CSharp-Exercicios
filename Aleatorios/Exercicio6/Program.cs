internal class Program
{
    private static void Main(string[] args)
    {
        /* 6) Faça um programa que:
            a) Obtenha o valor para a variável HT (horas trabalhadas no mês);
            b) Obtenha o valor para a variável VH (valor hora trabalhada):
            c) Obtenha o valor para a variável PD (percentual de desconto);
            d) Calcule o salário bruto => SB = HT * VH;
            e) Calcule o total de desconto => TD = (PD/100)*SB;
            f) Calcule o salário líquido => SL = SB – TD;
            g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário Liquido */


        double HT, VH, SB, PD=5, TD, SL;

        Console.WriteLine("Digite as horas trabalhadas no mês: ");
        HT=double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor hora trabalhada: ");
        VH=double.Parse(Console.ReadLine());

        SB=HT*VH;
        TD=(PD/100)*SB;
        SL=SB-TD;

        Console.WriteLine("Horas trabalhadas: " + HT);
        Console.WriteLine("Salário Bruto: R$ " + SB);
        Console.WriteLine("Desconto: R$ " + TD);
        Console.WriteLine("Salário liquido: R$ " + SL);

    }
}