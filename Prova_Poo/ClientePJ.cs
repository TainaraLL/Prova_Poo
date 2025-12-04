public class ClientePJ : Cliente
{
    public string _cnpj {  get; set; }
    public string _nomeFantasia { get; set; }
    public string _razaoSocial { get; set; }

    public override double DescontoEspecial(double valor)
    {
        if (valor > 500 && valor < 1000)
        {
            valor -= valor * 6 / 100;
        }

        else if (valor > 1000)
        {
            valor -= valor * 9 / 100;
        }

        else
        {
            throw new Exception("Valor Inválido!");
        }

        return valor;
    }
}