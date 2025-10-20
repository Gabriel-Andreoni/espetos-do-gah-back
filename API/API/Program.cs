using API.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<LevantamentoContext>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost3000",
        policy =>
            policy.WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("AllowLocalhost3000");

app.LevantamentoRoutes();

app.Run();