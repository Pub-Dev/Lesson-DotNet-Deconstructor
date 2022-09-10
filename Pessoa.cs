public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Endereco { get; set; }
    public int Idade { get; set; }

    // Utilizando desconstrutor para obter as propriedades do objeto
    public void Deconstruct(out string nome, out string sobrenome, out string endereco, out int idade)
    {
        nome = Nome;
        sobrenome = Sobrenome;
        endereco = Endereco;
        idade = Idade;
    }

    public void Deconstruct(out string nome, out string sobrenome, out string endereco)
    {
        nome = Nome;
        sobrenome = Sobrenome;
        endereco = Endereco;
    }

    // Utilizando Tuplas para retornar as propriedades do objeto
    public (string nome, string sobrenome, string endereco, int idade) ObterPropriedades()
    {
        return (Nome, Sobrenome, Endereco, Idade);
    }
}