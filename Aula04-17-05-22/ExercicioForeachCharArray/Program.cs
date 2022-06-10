Console.WriteLine("Digite uma palavra:");
var minhapalavra = Console.ReadLine();
var charArray = minhapalavra.ToCharArray();

foreach (var cadaletra in charArray)
{
    Console.WriteLine(cadaletra);
}