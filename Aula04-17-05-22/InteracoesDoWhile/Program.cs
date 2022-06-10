// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite uma palavra");
var minhaPalavra = Console.ReadLine();
var minhaPalavraArray = minhaPalavra.ToCharArray();

int i = 0;
do
{
        Console.WriteLine(i + "-" + minhaPalavraArray[i]);
        i++;
} while (i < minhaPalavraArray.Length);
