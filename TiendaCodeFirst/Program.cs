using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Security.Policy;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Helpers;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<HelperOAuthToken>();
HelperOAuthToken helper = new HelperOAuthToken(builder.Configuration);
builder.Services.AddAuthentication(helper.GetAuthenticationOptions()).AddJwtBearer(helper.GetJwtBearerOptions());
string connectionString = builder.Configuration.GetConnectionString("SqlServer");
//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext<TiendaContext>(options =>
{
    options
    .UseSqlServer(connectionString);
    options.EnableSensitiveDataLogging();
});
builder.Services.AddMemoryCache();
builder.Services.AddTransient<IRepositoryLineaPedidoTienda, RepositoryLineaPedidoTienda>();
builder.Services.AddTransient<IRepositoryClientesTienda, RepositoryClientesTienda>();
builder.Services.AddTransient<IRepositoryPedidosTienda, RepositoryPedidosTienda>();
builder.Services.AddTransient<IRepositoryCategoriasTienda, RepositoryCategoriasTienda>();
builder.Services.AddTransient<IRepositoryMarcasTienda, RepositoryMarcasTienda>();
builder.Services.AddTransient<IRepositoryObjetosTienda, RepositoryObjetosTienda>();
builder.Services.AddTransient<IRepositoryProductosTienda, RepositoryProductosTienda>();
builder.Services.AddTransient<IRepositoryVentasTienda, RepositoryVentasTienda>();
builder.Services.AddTransient<IRepositoryLogTienda, RepositoryLogTienda>();
builder.Services.AddTransient<IRepositoryModelosTienda, RepositoryModelosTienda>();
builder.Services.AddTransient<IRepositoryRecepcionMaterialTienda, RepositoryRecepcionMaterialTienda>();
builder.Services.AddSingleton<HelperPathProvider>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithExposedHeaders("Content-Type"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    TiendaContext context = scope.ServiceProvider.GetService<TiendaContext>();
    context.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint(
        url: "swagger/v1/swagger.json", name: "Api Productos"
        );
    options.RoutePrefix = "";
});

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithExposedHeaders("Content-Type"));

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
