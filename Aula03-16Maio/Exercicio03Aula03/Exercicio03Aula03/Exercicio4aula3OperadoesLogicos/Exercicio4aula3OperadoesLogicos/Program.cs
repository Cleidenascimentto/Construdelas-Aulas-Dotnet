
Console.WriteLine("Digite um número:");
int.TryParse(Console.ReadLine(), out int n1);
Console.WriteLine("Digite outro número:");
int.TryParse (Console.ReadLine(), out int n2);  
Console.WriteLine($" {n1} >= {n2}: {n1>=n2}");
