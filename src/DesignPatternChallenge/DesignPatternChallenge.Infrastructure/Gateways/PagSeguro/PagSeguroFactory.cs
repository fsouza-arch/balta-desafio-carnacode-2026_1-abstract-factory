using DesignPatternChallenge.Dominio.Interfaces;

namespace DesignPatternChallenge.Infrastructure.Gateways.PagSeguro;

public class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new PagSeguroValidator();
    public IPaymentProcessor CreateProcessor() => new PagSeguroProcessor();
    public IPaymentLogger CreateLogger() => new PagSeguroLogger();
}