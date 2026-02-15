namespace DesignPatternChallenge.Dominio.Interfaces;

public interface IPaymentGatewayFactory
{
    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}