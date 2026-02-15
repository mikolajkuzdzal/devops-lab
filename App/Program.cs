var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { status = "ok" }));

app.MapGet("/products", () =>
{
    var products = new[]
    {
        new { Id = 1, Name = "Keyboard", Price = 199.99 },
        new { Id = 2, Name = "Mouse", Price = 79.99 }
    };

    return Results.Ok(products);
});

app.Run();
