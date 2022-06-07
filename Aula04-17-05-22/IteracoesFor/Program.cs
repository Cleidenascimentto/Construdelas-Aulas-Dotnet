// See https://aka.ms/new-console-template for more information
    Console.WriteLine("Digite um número");
    var númeroStr = Console.ReadLine();

    var numero = Convert.ToInt32(númeroStr);
    for (int i = 0; i < numero; i++)
{
    Console.WriteLine($"olha aqui eu no loop - {i}");
}
