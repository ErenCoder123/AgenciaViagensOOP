//criadno as listas
var destinos = new List<Destino>();
var clientes = new List<Cliente>();
var pacotes = new List<PacoteTuristico>();
var reservas = new List<Reserva>();

//istanciadno agencia
var agencia1 = new Agencia(destinos, clientes, pacotes, reservas);
Console.WriteLine();

//instanciando destinos
var paris = new Destino("Paris", "França", "3", "cidade linda paris");
paris.ExibirInformacoes();
var berlin = new Destino("Berlin", "Alemanha", "4", "cidade linda berlin");
berlin.ExibirInformacoes();

//instanciando clientes
var cliente1 = new Cliente("cleitinho", "1", "123456789", agencia1);
var midel = new Cliente("Midel", "2","48991655132", agencia1);
midel.ExibirInformacoes();
Console.WriteLine();

//instanciando pacotes
var pacote1 = new PacoteTuristico("1", "Viagem lindissima pra Paris", paris, new DateTime(2024, 12, 20), new DateTime(2024, 12, 30), 1250.50m, 5);
pacote1.ExibirInformacoes();
var pacote2 = new PacoteTuristico("2", "Viagem lindissima pra Berlin", berlin, new DateTime(2024, 11, 15), new DateTime(2024, 11, 30), 1330.50m, 4);
pacote2.ExibirInformacoes();
Console.WriteLine();

//objeto agencia fazendo os gerenciamentos
agencia1.CadastrarDestino(paris);
agencia1.CadastrarDestino(berlin);
agencia1.CadastrarPacote(pacote1);
agencia1.CadastrarPacote(pacote2);
agencia1.CadastrarCliente(cliente1);
agencia1.CadastrarCliente(midel);
Console.WriteLine();
agencia1.ListarClientes();
Console.WriteLine();
agencia1.ListarDestinos();
Console.WriteLine();
agencia1.ListarPacotes();
Console.WriteLine();
agencia1.ReservarPacote("1", midel);
agencia1.ReservarPacote("2", cliente1);
agencia1.CancelarReserva("1");
agencia1.CancelarReserva("2");
Console.WriteLine();

//pesquisar por destino
var pacotesParaParis = cliente1.PesquisarPorDestino("Berlin");
foreach (var pacote in pacotesParaParis)
{
    Console.WriteLine($"Pacote com esse destino: {pacote.Descricao}, Preço: {pacote.Preco}, Data: {pacote.DataInicio.ToShortDateString()}");
}

//pesquisar por dat
var pacotesParaData = cliente1.PesquisarPorData(new DateTime(2024, 12, 20));
foreach (var pacote in pacotesParaData)
{
    Console.WriteLine($"Pacote nesta data: {pacote.Descricao}, Preço: {pacote.Preco}, Data: {pacote.DataInicio.ToShortDateString()}");
}

//pesquisar por preço
var pacotesNaFaixa = cliente1.PesquisarPorPreco(1000m, 2000m);
foreach (var pacote in pacotesNaFaixa)
{
    Console.WriteLine($"Pacote nessa faixa de preço: {pacote.Descricao}, Preço: {pacote.Preco}, Data: {pacote.DataInicio.ToShortDateString()}");
}

