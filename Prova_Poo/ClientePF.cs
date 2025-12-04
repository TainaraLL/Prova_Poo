public class ClientePF : Cliente
{
    public string _cpf;
    public DateOnly _dataNasc;
    public string _nome;

    public ClientePF()
    {

    }

    public override double DescontoEspecial(double valor)
    {
        if (valor > 500 && valor < 1000)
        {
            valor -= valor * 5 / 100;
        }

        else if (valor > 1000)
        {
            valor -= valor * 7 / 100;
        }

        else
        {
            throw new Exception("Valor Inválido!");
        }

        return valor;
    }
}