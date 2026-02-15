using DesignPatternChallenge.Dominio.Interfaces;

namespace DesignPatternChallenge.Infrastructure.Gateways.Stripe;

public class StripeFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new StripeValidator();
    public IPaymentProcessor CreateProcessor() => new StripeProcessor();
    public IPaymentLogger CreateLogger() => new StripeLogger();
}