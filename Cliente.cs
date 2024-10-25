public class Cliente

{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Contato  { get; set; }
    private Agencia Agencia { get; set; }
    
    public Cliente(string nome, string numeroId, string contato, Agencia agencia)
    {
        Nome = nome;
        NumeroIdentificacao = numeroId;
        Contato = contato;
        Agencia = agencia;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações do Cliente:");
        Console.WriteLine($"\nNome: {Nome}\nID: {NumeroIdentificacao}\nContato: {Contato}");
    }

    public List<PacoteTuristico> PesquisarPorDestino(string nomeDestino)
    {
        return Agencia.Pacotes.Where(p => p.Destino.NomeLocal.Equals(nomeDestino, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<PacoteTuristico> PesquisarPorData(DateTime dataInicio)
    {
        return Agencia.Pacotes.Where(p => p.DataInicio.Date == dataInicio.Date).ToList();
    }

    public List<PacoteTuristico> PesquisarPorPreco(decimal precoMinimo, decimal precoMaximo)
    {
        return Agencia.Pacotes.Where(p => p.Preco >= precoMinimo && p.Preco <= precoMaximo).ToList();
    }
}