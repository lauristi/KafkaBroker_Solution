using Net.Delivery.Order.Domain.Services;
using Net.Delivery.Order.Domain.Services.Interface;
using Net.Delivery.Order.Notifier;

var builder = Host.CreateApplicationBuilder(args);

// Adiciona o serviço Worker como um serviço hospedado
builder.Services.AddHostedService<Worker>();

// Registra NotifierService como a implementação de INotifierService
builder.Services.AddScoped<INotifierService, NotifierService>();

var host = builder.Build();
host.Run();