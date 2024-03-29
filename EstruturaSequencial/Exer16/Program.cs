﻿internal class Program
{
    private static void Main(string[] args)
    {
        /*
        16. Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada.
        Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que
        custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
        */

        Console.WriteLine("Metros da área a ser pintada: ");
		double metros = double.Parse(Console.ReadLine());
		
		double litro = metros / 3; // 1 litro para cada 3 metros quadrados 
		double lataValor = 80.0; // Cada tinta R$ 80,00.
		double lataCapacidade = 18.0; // latas de 18 litros.
		
		double latas = litro / lataCapacidade; //quantidades de latas de tinta.
		double preco = latas * lataValor; // quantidades de latas de tinta.
		
		Console.WriteLine("Tintas a serem usadas: " + latas.ToString("F") + " Latas");
		Console.WriteLine("Valor a ser gasto: R$ " + preco.ToString("F"));
    }
}