Console.WriteLine ("Digite um mes");
var mes = Console.ReadLine();
var mesMinusculo = mes.ToLower();

switch (mesMinusculo)
{
case "janeiro":
case "março":
case "maio":
case "julho":
case "agosto":
case "outubro":
case "dezembro":
Console.WriteLine("Este mês tem 31 dias");
break;
case "fevereiro":
Console.WriteLine("Este mês tem 28 ou 29 dias");
break;
case "abril":
case "junho":
case "setembro":
case "novembro":
Console.WriteLine("Este mês tem 30 dias");
break;
default:
Console.WriteLine("Digite um mes valido");
break;
}

