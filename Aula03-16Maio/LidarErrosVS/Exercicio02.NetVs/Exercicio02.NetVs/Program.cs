Console.WriteLine("Digite o dia do seu aniversário no formato DD/MM/AAAA");
string dataDeNascimentoStr = Console.ReadLine();
string diaStr = dataDeNascimentoStr.Substring(0, 2);
string mesStr = dataDeNascimentoStr.Substring(3, 2);
string anoStr = dataDeNascimentoStr.Substring(6, 4);

try
{
    short dia = Convert.ToInt16(diaStr);
    short mes = Convert.ToInt16(mesStr);
    short ano = Convert.ToInt16(anoStr);
    var dataDeNascimentoDate = new DateTime(ano, mes, dia);
    Console.WriteLine(dataDeNascimentoDate.DayOfWeek);

}
catch (Exception)
{
    Console.WriteLine("Digite a data no formato correto");
}

