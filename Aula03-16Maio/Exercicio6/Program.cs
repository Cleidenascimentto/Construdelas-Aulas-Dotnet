// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número: ");
var umNumero = Console.ReadLine();

Console.WriteLine("Digite outro número: ");
var outroNumero = Console.ReadLine();

try

{
var umNumeroInt = Convert.ToInt32(umNumero);
var outroNumeroInt = Convert.ToInt32(outroNumero);
Console.WriteLine( umNumeroInt > outroNumeroInt && outroNumeroInt % 2 == 0);

}
catch (Exception)
{
Console.WriteLine("Digite o número corretamente");
}