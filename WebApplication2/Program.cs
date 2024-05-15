var builder = WebApplication.CreateBuilder(args).Inject();

// Add services to the container.

builder.Services.AddControllers().AddInjectWithUnifyResult();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.UseInject();

app.MapControllers();



app.Run();
