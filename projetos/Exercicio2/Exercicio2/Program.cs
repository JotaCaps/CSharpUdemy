﻿// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem a casa? ");
int qtdQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço do produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
string[] vet = Console.ReadLine().Split();
string ultimoNome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(qtdQuartos);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
