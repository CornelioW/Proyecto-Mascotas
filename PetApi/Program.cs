using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PetApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configurar Entity Framework Core con SQL Server
builder.Services.AddDbContext<PetContext>(options =>
    options.UseSqlServer(connectionString));

// Agregar controladores
builder.Services.AddControllers();

var app = builder.Build();

// Middleware de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Configurar rutas de la API
app.MapControllers();

app.Run();
