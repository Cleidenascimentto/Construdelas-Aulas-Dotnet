// Condiçoes if else usando no c# ,servedot
Console.WriteLine("21");
var 10 = Console.ReadLine();
Console.WriteLine("03");
var 1984 = Console.ReadLine();

if (int.TryParse(umNumero, out int umNumeroInt) == false)
{
    Console.WriteLine("Digite um numero valido");
}
else // se o numero for invalido
    if (int.TryParse(outroNumero, out int outroNumeroInt) == false)
    {
        Console.WriteLine("Digite outro numero valido");
    }
    else
        Console.WriteLine(umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);