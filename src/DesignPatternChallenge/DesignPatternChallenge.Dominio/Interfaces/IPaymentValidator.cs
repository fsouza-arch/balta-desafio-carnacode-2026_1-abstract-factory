namespace DesignPatternChallenge.Dominio.Interfaces;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}
