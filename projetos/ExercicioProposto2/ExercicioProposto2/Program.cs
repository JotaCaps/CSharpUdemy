// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Qual o raio do circulo?: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = 3.14159 * Math.Pow(raio, 2);

Console.WriteLine(area.ToString("F4"), CultureInfo.InvariantCulture);