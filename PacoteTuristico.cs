using System.Reflection.Metadata.Ecma335;

public class PacoteTuristico : ServicoViagem
{

    public Destino Destino { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public decimal Preco { get; set; }
    public int VagasDisponiveis { get; set; }

    public PacoteTuristico(string codigo, string descricao, Destino destino, DateTime dataInicio, DateTime dataFim, decimal preco, int vagasdisp) : base (codigo, descricao)
    {
        Destino = destino;
        DataInicio = dataInicio;
        DataFim = dataFim;
        Preco = preco;
        VagasDisponiveis = vagasdisp;
    }

    public override void Reservar()
    {
        if(VagasDisponiveis > 0)
        {
            VagasDisponiveis--;
            Console.WriteLine("Reserva confirmada é us guri boa viagem");
        }
        else
        {
            Console.WriteLine($"cabo as vaga");
        }
    }

    public override void Cancelar()
    {
        VagasDisponiveis++;
        Console.WriteLine("Reserva cancelada é us guri boa viagem");
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"{Codigo}\n{Descricao}\n{Destino.NomeLocal}\n{DataInicio.ToString("dd/MM/yyyy")}\n{DataFim.ToString("dd/MM/yyyy")}\n{Preco}\n{VagasDisponiveis}");
    }

    public string PequisarPorCodigo()
    {
        return Codigo;
    }

    public Destino PesquisarPorDestino()
    {
        return Destino;
    }


}