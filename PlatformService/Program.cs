using PlatformService.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PlatformConnectionString");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(connectionString));

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();