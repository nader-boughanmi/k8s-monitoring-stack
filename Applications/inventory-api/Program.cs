var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseHttpsRedirection();

app.MapGet("/servers", () =>
{
    return new[]
    {
        new
        {
            Id = 1,
            Hostname = "SRV-APP-01",
            IP = "10.10.10.1",
            Environment = "PROD"
        },
        new
        {
            Id = 2,
            Hostname = "SRV-SQL-01",
            IP = "10.10.10.20",
            Environment = "PREPROD"
        }
    };
});
app.Run();
