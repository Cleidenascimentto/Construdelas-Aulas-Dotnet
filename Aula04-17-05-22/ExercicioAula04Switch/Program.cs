// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número");
String n = Console.ReadLine();
String ultimoDigito = n.Substring((n.Length -1), 1);// imprime o ultimo digito do numero

switch (ultimoDigito)
{
    case "0":
    case "2":
    case "4":
    case "6":
    case "8":
        Console.WriteLine("Este número é par");
        break;
    default:
    case "1":
    case "3":
    case "5":
    case "7":
    case "9":

        Console.WriteLine("Este número é impar");
    break;
    
}
