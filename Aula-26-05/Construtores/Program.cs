
using System;


var pessoa = new Pessoa();
pessoa.nome = "thays";
pessoa.email = "thaystg@gmail.com";


Console.WriteLine(pessoa.nome);
Console.WriteLine(pessoa.email);
class Pessoa
{​​​​​​
    public string nome; //atributos
    public string email; //atributos
}​​​​​​
 




​[19:44] Thays Grazia (Convidado)
    
using System;
var pessoa = new Pessoa("thays", "thaystg@gmail.com");
var pessoa2 = new Pessoa("raquel");
Console.WriteLine(pessoa.nome);
Console.WriteLine(pessoa.email);


Console.WriteLine(pessoa2.nome);
Console.WriteLine(pessoa2.email);


class Pessoa
{​​​​​​
    public string nome;
    public string email;
    public Pessoa(string nome, string email)
    {​​​​​​
        this.nome = nome;
        this.email = email;
    }​​​​​​


    public Pessoa(string nome)
    {​​​​​​
        this.nome = nome;
        this.email = "nao informado";
    }​​​​​​
}​​​​​​
 






