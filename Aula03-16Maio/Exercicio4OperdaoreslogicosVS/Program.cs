// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o primeiro número:");
var numeroStr = Console.ReadLine();
var numero = Convert.ToInt32(numeroStr);
Console.WriteLine("Digite o segundo número:");
var numero2Str = Console.ReadLine();
var numero2 = Convert.ToInt32(numero2Str);
Console.WriteLine(numero >= numero2);