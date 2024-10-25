public abstract class ServicoViagem
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }

    protected ServicoViagem(string codigo, string descricao)
    {
        Codigo = codigo;
        Descricao = descricao;
    }

    public abstract void Reservar();

    public abstract void Cancelar();

    public abstract void ExibirInformacoes();
}