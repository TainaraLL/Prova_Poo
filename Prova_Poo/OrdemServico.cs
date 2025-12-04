public class OrdemServico
{
    public int _id {  get; set; }
    public DateOnly _dataInicio { get; set; }
    public string _status { get; set; }
    public double _porcDesconto { get; set; }
    public double _valorFinal {  get; set; }

    public Veiculo _veiculo;

    public Cliente _cliente;

    public List<ItemServico> listItens = new List<ItemServico>();

    public OrdemServico()
    {
        // listItens.Add(new List<ItemServico>());

        List<ItemServico> listItens = new List<ItemServico>();

        CalcularValorFinal();
    }

    public double CalcularValorFinal()
    {
        //double valor = listItens._valorUnit;

        return _valorFinal;
    }
}