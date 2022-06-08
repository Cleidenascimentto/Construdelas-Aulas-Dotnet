Console.WriteLine("Digite um numero");
var numeroAstr = Console.ReadLine();
Console.WriteLine("Digite um numero");
var numeroBstr = Console.ReadLine();

var numeroA = Convert.ToInt32(numeroAstr);
var numeroB = Convert.ToInt32(numeroBstr);

int multiplicacao = 0;
for (int i = 0; 1 < numeroB; i++)
{
    multiplicacao += numeroA;
}
Console.WriteLine(multiplicacao);