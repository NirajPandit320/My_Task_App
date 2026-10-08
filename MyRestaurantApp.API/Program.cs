using MyRestaurantApp.API.Services;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //prepare the restaurant to use waiters.
builder.Services.AddScoped<FoodService>(); //telling the restaurant to use the FoodService class as a waiter

var app = builder.Build();

app.MapControllers(); //tell the restaurant to send customer requests to the appropriate waiter.

app.Run(); //this is telling the application to start running, like opening the restaurant doors for customers