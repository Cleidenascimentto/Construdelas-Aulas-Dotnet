// See https://aka.ms/new-console-template for more information
var a = "OlaCleide";
try
{
    Convert.ToInt32(a);
    Console.WriteLine("lalalla");
}
catch (Exception e)
{
    Console.WriteLine("Deu erro");
    Console.WriteLine(e.ToString());
}