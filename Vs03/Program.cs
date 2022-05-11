string a = Console.ReadLine();
string b = Console.ReadLine();
int aConvertido, bConvertido;

int.TryParse(a, out aConvertido);
int.TryParse(b, out bConvertido);
int c = aConvertido + bConvertido;

Console.WriteLine(c);