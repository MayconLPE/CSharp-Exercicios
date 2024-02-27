internal class Program
{
    private static void Main(string[] args)
    {
        /*oão Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar o rendimento diário de seu trabalho. Toda
            vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos)
            deve pagar uma multa de R$ 4,00 por quilo excedente. João precisa que você faça um programa que leia a variável peso (peso
            de peixes) e calcule o excesso. Gravar na variável excesso a quantidade de quilos além do limite e na variável multa o valor da
            multa que João deverá pagar. Imprima os dados do programa com as mensagens adequadas.
        */
        double pesoPeixes;

        Console.WriteLine("Digite o peso dos Peixes: ");
        pesoPeixes = double.Parse(Console.ReadLine());

        if (pesoPeixes > 50) {
			Double multaValor = (pesoPeixes - 50)* 4; // Valor de multa.
			Console.WriteLine("Peso ultrapassado valor a ser pago com multa é: R$ " + multaValor);
		}
		else {
			Console.WriteLine("Peso não ultrapassado sem pagamentos de multa."); // Valor sem multa.
		}
    }
}