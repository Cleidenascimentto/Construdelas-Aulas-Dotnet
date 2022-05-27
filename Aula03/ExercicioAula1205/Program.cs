// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a primeira string:");
var primeira = Console.ReadLine();
Console.WriteLine("Digite  a segunda string:");
var segunda = Console.ReadLine();
Console.WriteLine(primeira + segunda);
Console.WriteLine(primeira.IndexOf(segunda));
Console.WriteLine(primeira.ToCharArray()[2]);