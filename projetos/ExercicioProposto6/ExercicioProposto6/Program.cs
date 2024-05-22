// See https://aka.ms/new-console-template for more information
using System.Globalization;

string[] produto1 = Console.ReadLine().Split(' ');

int codigoPeca1 = int.Parse(produto1[0]);
int numeroDePecas1 = int.Parse(produto1[1]);
double valorUnitario1 = double.Parse(produto1[2], CultureInfo.InvariantCulture);

string[] produto2 = Console.ReadLine().Split(' ');

int codigoPeca2 = int.Parse(produto2[0]);
int numeroDePecas2 = int.Parse(produto2[1]);
double valorUnitario2 = double.Parse(produto2[2], CultureInfo.InvariantCulture);

double valorTotal = valorUnitario1 * numeroDePecas1 + valorUnitario2 * numeroDePecas2;

Console.WriteLine($"VALOR A PAGAR {valorTotal.ToString("F2")}");

