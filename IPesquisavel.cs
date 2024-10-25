public interface IPesquisavel
{
    string PequisarPorCodigo(string codigo);

    string PequisarPorNome(string nome);

    decimal PesquisarPorPreco(decimal preco);

    DateTime PesquisarPorData(DateTime Data);

    string PequisarPorDestino(string destino);
}