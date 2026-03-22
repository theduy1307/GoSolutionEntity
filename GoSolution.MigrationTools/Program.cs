using GoSolution.Entity;
using Microsoft.EntityFrameworkCore;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddDbContext<PoseidonDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var host = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Gọi SeedData
using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;
}

host.Run();