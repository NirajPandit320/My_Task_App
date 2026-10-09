using MyRestaurantApp.API.Services;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //prepare the restaurant to use waiters.
builder.Services.AddScoped<FoodService>(); //This registers FoodService with .NET's dependency injection system.

var app = builder.Build();

app.MapControllers(); //tell the restaurant to send customer requests to the appropriate waiter.

app.Run(); //this is telling the application to start running, like opening the restaurant doors for customers