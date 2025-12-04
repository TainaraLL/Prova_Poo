try
{
    //  CLIENTE PF
    ClientePF pf = new ClientePF();

    pf._telefone = "69 998078976";
    pf._dataCad = new DateOnly(2025, 12, 03);
    pf._nome = "João do teste";
    pf._dataNasc = new DateOnly(1989, 09, 22);
    pf._cpf = "023.589.756-75";


    //  SERVIÇO
    Servico serv = new Servico();

    serv._descricao = "Troca de óleo";
    serv._valorSugerido = 180;
    serv._tempoEstimado = new TimeSpan(00, 30, 00);


    //  ORDEM SERVIÇO
    OrdemServico ordemS = new OrdemServico();

    ordemS._dataInicio = new DateOnly(2025, 12, 03);
    ordemS._status = "Aberto";
    ordemS._porcDesconto = 2;
    //ordemS._cliente = pf._nome;


    //  ITEM SERVIÇO
    ItemServico itemS = new ItemServico();

    itemS._valorUnit = 180;
    itemS.SetQuant(2);

    Console.WriteLine($"Quantidade: {itemS.GetQuant()}");


    Console.WriteLine($"\nCliente PF - Valor com Desconto: {pf.DescontoEspecial(750)}\n");
    ClientePJ pj = new ClientePJ();
    Console.WriteLine($"Cliente PJ - Valor com Desconto: {pj.DescontoEspecial(1500)}\n");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}