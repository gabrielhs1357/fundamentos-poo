var pagamentoViaPix = new PagamentoViaPix(DateTime.Now, 125);

Console.WriteLine(pagamentoViaPix.DataPagamento);
Console.WriteLine(pagamentoViaPix.Teste);

Console.WriteLine("Hello, World!");

class Pagamento
{
    public DateTime DataPagamento { get; set; }

    public Pagamento(DateTime dataPagamento)
    {
        DataPagamento = dataPagamento;
    }
}

class PagamentoViaPix : Pagamento
{
    public int Teste { get; set; }

    public PagamentoViaPix(DateTime dataPagamento, int teste) : base(dataPagamento)
    {
        Teste = teste;
    }
}

namespace Payments
{

}
