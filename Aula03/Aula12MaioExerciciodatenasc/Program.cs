Console.WriteLine("Digite o dia do seu aniversario");
var dia = Console.ReadLine();
Console.WriteLine("Digite o mes do seu aniversario");
var mes = Console.ReadLine();
Console.WriteLine("Digite o ano do seu aniversario");
var ano = Console.ReadLine();

var diaInteiro = Convert.ToInt32(dia);
var mesInteiro = Convert.ToInt32(mes);
var anoInteiro = Convert.ToInt32(ano);

var dataDoAniversario = new DateTime(anoInteiro, mesInteiro, diaInteiro);

Console.WriteLine(dataDoAniversario.DayOfWeek);
Console.WriteLine(dataDoAniversario.DayOfYear);

