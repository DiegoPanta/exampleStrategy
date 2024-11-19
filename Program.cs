namespace exampleStrategy;

class Program
{
    static void Main(string[] args)
    {
        decimal precoOriginal = 100.0m;

        IDescontoStrategy descontoPadrao = new DescontoPadraoBusiness();
        Pedido pedidoComDescontoPadrao = new Pedido(descontoPadrao);
        Console.WriteLine($"Preço com desconto padrão: {pedidoComDescontoPadrao.CalcularPrecoComDesconto(precoOriginal)}");

        IDescontoStrategy descontoVIP = new DescontoVIPBusiness();
        Pedido pedidoComDescontoVIP = new Pedido(descontoVIP);
        Console.WriteLine($"Preço com desconto VIP: {pedidoComDescontoVIP.CalcularPrecoComDesconto(precoOriginal)}");
    }
}
