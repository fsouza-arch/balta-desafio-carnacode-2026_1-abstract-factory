using DesignPatternChallenge.Dominio.Interfaces;

namespace DesignPatternChallenge.Infrastructure.Gateways.MercadoPago;

public class MercadoPagoProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
        return $"MP-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}