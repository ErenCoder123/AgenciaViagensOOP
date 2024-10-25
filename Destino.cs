public class Destino
{
    public string NomeLocal { get; set; }
    public string Pais { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }

    public Destino(string nomelocal, string pais, string codigo, string descricao)
    {
        NomeLocal = nomelocal;
        Pais = pais;
        Codigo = codigo;
        Descricao = descricao;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações do Destino:");
        Console.WriteLine($"\nDestino: {NomeLocal}\nPais: {Pais}\nCódigo: {Codigo}\nDescrição: {Descricao}");
    }

    public string PequisarPorCodigo()
    {
        return Codigo;
    }

    public string PesquisarPorDestino()
    {
        return Pais;
    }
}