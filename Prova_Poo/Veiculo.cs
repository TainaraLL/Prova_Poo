public class Veiculo
{
    public string _placa {  get; set; }
    public string _modelo { get; set; }
    public string _marca { get; set; }
    public DateOnly _dataFabric { get; set; }

    public Cliente _cliente { get; set; }
}
