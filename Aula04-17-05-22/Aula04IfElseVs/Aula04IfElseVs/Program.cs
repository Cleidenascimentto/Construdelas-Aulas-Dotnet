
Console.WriteLine("Digite um numero"); 
var umNumero = Console.ReadLine();
Console.WriteLine("Digite outro numero");
var outroNumero = Console.ReadLine();

if (int.TryParse(umNumero, out int umNumeroInt) == false)
{
    Console.WriteLine("Digite um numero valido");
}
else
{
    if (int.TryParse(outroNumero, out int outroNumeroInt) == false)
    {
        Console.WriteLine("Digite outro numero valido");
    }
    else
    {
        Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);
    }
}

