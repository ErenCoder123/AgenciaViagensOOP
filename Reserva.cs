public class Reserva
{
    private static int contadorCodigoReserva = 1;
    public string CodigoReserva { get; private set; }
    public PacoteTuristico Pacote { get; private set; }
    public Cliente Cliente { get; private set; }
    public bool Cancelada { get; private set; }

    public Reserva(PacoteTuristico pacote, Cliente cliente)
    {
        CodigoReserva = contadorCodigoReserva.ToString();
        Pacote = pacote;
        Cliente = cliente;
        Cancelada = false;
        contadorCodigoReserva++;
    }
}
