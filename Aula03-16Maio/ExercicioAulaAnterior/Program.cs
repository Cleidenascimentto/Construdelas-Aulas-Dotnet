// Peça para o usuário digitar o dia do aniversário no formato DD/MM/AAAA
// Crie uma data e imprima qual o dia da semana ele nasceu.

Console.WriteLine("Digite o dia do seu aniversário no formato DD/MM/AAAA");
string dataDeNascimentoStr = Console.ReadLine();
string diaStr = dataDeNascimentoStr.Substring(0, 2);
string mesStr = dataDeNascimentoStr.Substring(3, 2);
string anoStr = dataDeNascimentoStr.Substring(6, 4);
short dia = Convert.ToInt16(diaStr);
short mes = Convert.ToInt16(mesStr);
short ano = Convert.ToInt16(anoStr);
var dataDeNascimentoDate = new DateTime(ano, mes, dia);
Console.WriteLine(dataDeNascimentoDate.DayOfWeek);