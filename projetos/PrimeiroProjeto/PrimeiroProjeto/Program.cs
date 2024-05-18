// See https://aka.ms/new-console-template for more information
using System.Globalization;


Console.WriteLine("Hello, World!");

int idade = 32;
double saldo = 10.4352;
string nome = "Maria";

Console.WriteLine($"{nome} tem {idade} anos e tem {saldo:F2} na conta!");

Console.WriteLine(nome + " tem " + idade + " e tem " + saldo.ToString(CultureInfo.InvariantCulture) + " reais! ");
