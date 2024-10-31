using System.Net.WebSockets;

public class Agencia
{

    public List<Destino> Destinos { get; set; }
    public List<Cliente> Clientes { get; set; }
    public List<PacoteTuristico> Pacotes { get; set; }
    public List<Reserva> Reservas { get; set; }


    public Agencia(List<Destino> destinos, List<Cliente> clientes, List<PacoteTuristico> pacotes, List<Reserva> reservas)
    {
        Destinos = destinos;
        Clientes = clientes;
        Pacotes = pacotes;
        Reservas = reservas;
    }

    public void CadastrarDestino(Destino destino)
    {
        if (destino == null)
        {
            Console.WriteLine("Destino inválido.");
            return;
        }

        if (Destinos.Any(destinos => destinos.Codigo == destino.Codigo))
        {
            Console.WriteLine("Um destino com este código já está cadastrado.");
            return;
        }

        Destinos.Add(destino);
        Console.WriteLine($"Destino {destino.NomeLocal} cadastrado.");
    }

    public Destino? ConsultarDestinoPorCodigo(string codigo)
    {
        foreach (var destino in Destinos)
        {
            if (destino.Codigo == codigo)
            {
                return destino;
            }
        }
        Console.WriteLine("Destino não encontrado");
        return null;
        
    }

    public void ListarDestinos()
    {
        Console.WriteLine("Destinos:");
        foreach (var destino in Destinos)
    {
        Console.WriteLine($"Nome do Local: {destino.NomeLocal}, País: {destino.Pais}, Código: {destino.Codigo}, Descrição: {destino.Descricao}");
    }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente == null)
        {
            Console.WriteLine("Cliente inválido.");
            return;
        }

        if (Clientes.Any(clientes => clientes.NumeroIdentificacao == cliente.NumeroIdentificacao))
        {
            Console.WriteLine("Um cliente com este ID já está cadastrado.");
            return;
        }

        Clientes.Add(cliente);
        Console.WriteLine($"Cliente {cliente.Nome} cadastrado.");
    }

    public Cliente ConsultarClientePorID(string numeroIdentificacao)
    {
        foreach (var cliente in Clientes)
        {
        if (cliente.NumeroIdentificacao == numeroIdentificacao)
        {
            return cliente;
        }
        }
        Console.WriteLine("Cliente não encontrado");
        return null;
        
    }

    public void ListarClientes()
    {
        Console.WriteLine("Clientes:");
        foreach (var cliente in Clientes)
    {
        Console.WriteLine($"Nome: {cliente.Nome}, ID: {cliente.NumeroIdentificacao}, Contato: {cliente.Contato}");
    }
    }

    public void CadastrarPacote(PacoteTuristico pacote)
    {
        if (pacote == null)
        {
            Console.WriteLine("Pacote inválido.");
            return;
        }

        // if (Pacotes.Any(pacotes => pacote.Codigo == pacote.Codigo))
        // {
        //     Console.WriteLine("Um Pacote com este código já está cadastrado.");
        //     return;
        // }

        Pacotes.Add(pacote);
        Console.WriteLine($"Pacote {pacote.Descricao} cadastrado.");
    }

    public PacoteTuristico ConsultarPacotePorCodigo(string codigo)
    {
        foreach (var pacote in Pacotes)
        {
        if (pacote.Codigo == codigo)
        {
            return pacote;
        }
        }
        Console.WriteLine("Pacote não encontrado");
        return null;
    }

    public void ListarPacotes()
    {
        Console.WriteLine("Pacotes:");
        foreach (var pacote in Pacotes)
    {
        Console.WriteLine($"Código: {pacote.Codigo}, Descrição: {pacote.Descricao}, Destino: {pacote.Destino.NomeLocal}, Data de Inicio: {pacote.DataInicio.ToString("dd/MM/yyyy")}, Data de Retorno: {pacote.DataFim.ToString("dd/MM/yyyy")}, Preço: {pacote.Preco}. Vagas: {pacote.VagasDisponiveis}" );
    }
    }

    public void ReservarPacote(string codigoPacote, Cliente cliente)
    {
    PacoteTuristico pacote = ConsultarPacotePorCodigo(codigoPacote);
    if (pacote != null && cliente != null && Pacotes.Contains(pacote))
    {
        pacote.Reservar();
        var reserva = new Reserva(pacote, cliente);
        Reservas.Add(reserva);
        Console.WriteLine($"Código: {reserva.CodigoReserva}");
    }
    else
    {
        Console.WriteLine("Pacote ou cliente inválido.");
    }
}   

public void CancelarReserva(string codigoReserva)
{
    var reserva = Reservas.FirstOrDefault(r => r.CodigoReserva == codigoReserva);
    
    if (reserva == null)
    {
        Console.WriteLine("Reserva não encontrada.");
        return;
    }
    
    reserva.Pacote.Cancelar();
    
    Reservas.Remove(reserva);

    Console.WriteLine($"Código: {reserva.CodigoReserva}");
}
}