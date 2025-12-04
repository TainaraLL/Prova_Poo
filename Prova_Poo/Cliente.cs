public abstract class Cliente
{
    public int _id;
    public string _telefone;
    public string _email;
    public DateOnly _dataCad;

    public Cliente()
    {

    }

    public abstract double DescontoEspecial(double valor);
}