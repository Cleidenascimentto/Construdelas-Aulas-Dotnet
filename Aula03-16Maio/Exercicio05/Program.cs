// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número:");
var numero = Console.ReadLine();
var numeroint = Convert.ToInt32(numero);
Console.WriteLine((numeroint % 2) == 0);

