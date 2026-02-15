using DesignPatternChallenge.Dominio.Interfaces;

namespace DesignPatternChallenge.Infrastructure.Gateways.PagSeguro;

internal class PagSeguroLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}
