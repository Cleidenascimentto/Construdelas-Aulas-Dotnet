// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o primeiro número:");
var primeiroStr = Console.ReadLine();
Console.WriteLine("Digite o segundo número:");
var segundoStr = Console.ReadLine();
var primeiro = Convert.ToInt32(primeiroStr);
var segundo = Convert.ToInt32(segundoStr);
Console.WriteLine(!(primeiro > segundo || primeiro == segundo && primeiro < segundo));
