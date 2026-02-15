using DesignPatternChallenge.Infrastructure.Gateways.MercadoPago;
using DesignPatternChallenge.Infrastructure.Gateways.PagSeguro;
using DesignPatternChallenge.Infrastructure.Gateways.Stripe;
using DesignPatternChallenge.Service;

Console.WriteLine("=== Sistema de Pagamentos (Abstract Factory) ===\n");

// Exemplo com PagSeguro
Console.WriteLine("--- Testando PagSeguro ---");
var pagSeguroService = new PaymentService(new PagSeguroFactory());
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

// Exemplo com MercadoPago
Console.WriteLine("--- Testando MercadoPago ---");
var mercadoPagoService = new PaymentService(new MercadoPagoFactory());
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();

// Exemplo com Stripe
Console.WriteLine("--- Testando Stripe ---");
var stripeService = new PaymentService(new StripeFactory());
stripeService.ProcessPayment(300.00m, "4234567890123456");
