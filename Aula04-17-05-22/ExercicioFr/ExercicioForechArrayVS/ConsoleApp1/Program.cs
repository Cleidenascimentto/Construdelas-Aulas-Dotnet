// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite uma palavra:");
Console.ReadLine();
var minhapalavra = Console.ReadLine();
var charArray = minhapalavra.ToCharArray();

foreach (var cadaletra in charArray)
{
    Console.WriteLine(cadaletra);
}