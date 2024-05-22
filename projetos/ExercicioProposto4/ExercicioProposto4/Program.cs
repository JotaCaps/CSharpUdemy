// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Qual o númeor do funcionário?: ");
int numeorFuncionario = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas horas os funcionário trabalhou?: ");
int horasTrabalhadas = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto o funcionário ganha por hora?: ");
double valorHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioFuncionario = horasTrabalhadas * valorHoras;

Console.WriteLine($"NUMBER: {numeorFuncionario}");
Console.WriteLine($"SALARY: U$ {salarioFuncionario.ToString("F2")}");
