public class ItemServico
{
    public int _id {  get; set; }
    public double _valorUnit { get; set; }
    private int _quantidade {  get; set; }

    public Servico servico;

    public OrdemServico ordemServ;


    public void SetQuant(int quantidade)
    {
        if (quantidade > 0)
        {
            _quantidade = quantidade;
        }

        else
        {
            throw new Exception("A quantidade deve ser maior que zero!");
        }
    }

    public int GetQuant()
    {
        return _quantidade;
    }
}