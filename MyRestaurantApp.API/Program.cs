var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //prepare the restaurant to use waiters.

var app = builder.Build();

app.MapControllers(); //tell the restaurant to send customer requests to the appropriate waiter.

app.Run(); //this is telling the application to start running, like opening the restaurant doors for customers