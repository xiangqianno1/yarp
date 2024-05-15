using Furion;

var builder = WebApplication.CreateBuilder(args).Inject();

// Add services to the container.

builder.Services.AddControllers().AddInjectWithUnifyResult();
builder.Services.AddReverseProxy().LoadFromConfig(App.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.UseInject();
app.MapControllers();
app.MapReverseProxy();
app.Run();
