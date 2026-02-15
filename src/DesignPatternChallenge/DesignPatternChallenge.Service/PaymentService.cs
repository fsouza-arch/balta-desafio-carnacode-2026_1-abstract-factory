using DesignPatternChallenge.Dominio.Interfaces;

namespace DesignPatternChallenge.Service;

public class PaymentService
{
    private readonly IPaymentValidator _validator;
    private readonly IPaymentProcessor _processor;
    private readonly IPaymentLogger _logger;

    // O PaymentService agora recebe a fábrica ou os componentes já criados.
    // Usando a fábrica, garantimos que todos os componentes pertençam à mesma família.
    public PaymentService(IPaymentGatewayFactory factory)
    {
        _validator = factory.CreateValidator();
        _processor = factory.CreateProcessor();
        _logger = factory.CreateLogger();
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_validator.ValidateCard(cardNumber))
        {
            Console.WriteLine("Cartão inválido para o gateway selecionado.");
            return;
        }

        var result = _processor.ProcessTransaction(amount, cardNumber);
        _logger.Log($"Transação processada com sucesso: {result}");
    }
}