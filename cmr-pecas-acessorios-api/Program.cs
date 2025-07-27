using Cmr.Pecas.Acessorios.Domain.Repositories;
using Cmr.Pecas.Acessorios.Infra;
using Cmr.Pecas.Acessorios.Infra.Context;
using Cmr.Pecas.Acessorios.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<ProdutoService>();

builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<CategoriaService>();

builder.Services.AddTransient<IMarcaRepository, MarcaRepository>();
builder.Services.AddTransient<MarcaService>();


builder.Services.AddScoped<DatabaseContext>();

// Adiciona a seção ConnectionStrings ao sistema de opções
builder.Services.Configure<ConnectionString>(
builder.Configuration.GetSection("ConnectionString"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Adicione CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:4200", 
                               "https://localhost:7282") //TODO: Liberando acesso front-end por outro dominio
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});


var app = builder.Build();

// Use CORS
app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
