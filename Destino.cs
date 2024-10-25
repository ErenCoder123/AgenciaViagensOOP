public class Destino
{
    private string nomeLocal;
    private string pais;
    private string codigo;
    private string descricao;

    
    public Destino(string nomelocal, string pais, string codigo, string descricao)
    {
        this.nomeLocal = nomelocal;
        this.pais = pais;
        this.codigo = codigo;
        this.descricao = descricao;
    }

    public string NomeLocal
    {
        get { return nomeLocal; }
        set 
        { 
            if (!string.IsNullOrEmpty(value))
            {
                nomeLocal = value;
            }
        }
    }

    public string Pais
    {
        get { return pais; }
        set 
        { 
            if (!string.IsNullOrEmpty(value)) 
            {
                pais = value;
            }
        }
    }

    public string Codigo
    {
        get { return codigo; }
        set 
        { 
            if (!string.IsNullOrEmpty(value)) 
            {
                codigo = value;
            }
        }
    }

    public string Descricao
    {
        get { return descricao; }
        set 
        { 
            if (!string.IsNullOrEmpty(value)) 
            {
                descricao = value;
            }
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações do Destino:");
        Console.WriteLine($"\nDestino: {nomeLocal}\nPais: {pais}\nCódigo: {codigo}\nDescrição: {descricao}");
    }

    public string PesquisarPorCodigo()
    {
        return codigo;
    }

    public string PesquisarPorDestino()
    {
        return pais;
    }
}
