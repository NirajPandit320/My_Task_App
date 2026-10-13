using MyRestaurantApp.API.Services;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); 
builder.Services.AddScoped<FoodService>(); 

var app = builder.Build();

app.MapControllers(); 
app.Run(); 