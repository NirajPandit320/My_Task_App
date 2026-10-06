var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/api/foods", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Momo", Price = 150 },
        new { Id = 2, Name = "Pizza", Price = 300 },
        new { Id = 3, Name = "Burger", Price = 250 }
    };
});

app.Run();