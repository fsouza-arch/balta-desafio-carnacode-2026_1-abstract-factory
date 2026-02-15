using DesignPatternChallenge.Dominio.Interfaces;

namespace DesignPatternChallenge.Infrastructure.Gateways.Stripe;

internal class StripeValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("4");
    }
}