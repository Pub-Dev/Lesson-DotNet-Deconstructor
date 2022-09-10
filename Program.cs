
var pessoa = new Pessoa()
{
    Nome = "Humberto",
    Sobrenome = "Rodrigues",
    Endereco = "Rua Teste",
    Idade = 27
};

// obtendo dados via desconstrutor
(_, _, _, var idade) = pessoa;

//Console.WriteLine($"Desconstrutor = {idade}");

// obtendo dados via trupla
var dados = pessoa.ObterPropriedades();

// obtendos dados via tupla porem ignorando propriedades
(string nome_, _, _, var a) = pessoa.ObterPropriedades();

Console.WriteLine($"Via Tupla = {dados.idade}");

// obtendo dados via trupla identificada
var dadosTupla = ObterPropriedades();

//Console.WriteLine($"Nome = {dadosTupla.Nome}");
//Console.WriteLine($"Sobrenome = {dadosTupla.Sobrenome}");

(string Nome, string Sobrenome) ObterPropriedades()
{
    return ("Rafael", "Nagai");
}

// obtendo dados via trupla nao identificada
var dadosTuplaNaoIdentificadas = ObterPropriedadesNaoIdentificadas();

Console.WriteLine($"Nome = {dadosTuplaNaoIdentificadas.Item1}");
Console.WriteLine($"Sobrenome = {dadosTuplaNaoIdentificadas.Item2}");

(string, string) ObterPropriedadesNaoIdentificadas()
{
    return ("Humberto", "Rodrigues");
}

// desconstruindo dicionarios
var moedas = new Dictionary<string, string>
{
    {"BRL", "Real Brasileiro"},
    {"USD", "Dolar Americano"},
    {"CAD", "Dolar Canadense"},
    {"ARS", "Pesos Argentinos"}
};

foreach ((string iso, string descricao) in moedas)
{
    Console.WriteLine($"{iso}: {descricao}");
}


// desconstrindo usando extension methods

var data = new DateTime(2022, 1, 25);
(var ano, var mes, var dia) = data;

Console.WriteLine($"Ano = {ano}");
Console.WriteLine($"Mes = {mes}");
Console.WriteLine($"Dia = {dia}");

public static class ExtensionMethods
{
    public static void Deconstruct(this DateTime data, out int ano, out int mes, out int dia)
    {
        ano = data.Year;
        mes = data.Month;
        dia = data.Day;
    }
}
