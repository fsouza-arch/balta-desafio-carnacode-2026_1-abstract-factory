using DesignPatternChallenge.Dominio.Interfaces;

namespace DesignPatternChallenge.Infrastructure.Gateways.PagSeguro;

internal class PagSeguroProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}
