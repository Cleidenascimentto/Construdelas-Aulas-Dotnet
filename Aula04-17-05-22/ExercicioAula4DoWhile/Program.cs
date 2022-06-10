// See https://aka.ms/new-console-template for more information
int soma = 0;
string numeroStr;
int numero = 0;

do
{
        Console.WriteLine("Digite um números para somar ou 0 para resultado da soma");
        numeroStr = Console.ReadLine();
        numero = Convert.ToInt32(numeroStr);
        soma += numero;
} while (numero != 0);
     
Console.WriteLine (soma);
