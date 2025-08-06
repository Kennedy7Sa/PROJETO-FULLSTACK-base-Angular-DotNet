using ApiFuncionarios.DataContext;
using ApiFuncionarios.Services.Funcionario;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//injeção da coneção com o banco de dados 
builder.Services.AddDbContext<AppDbContexto>(options => options.UseSqlite(builder.Configuration
    .GetConnectionString("sqlite")));

//injeções de dependencia das interfaces funcionario 
builder.Services.AddScoped<IFuncionarioServiceInterface, FuncionarioService>();

//politicas de cors 
builder.Services.AddCors(options =>
{
    options.AddPolicy("projetoAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//usando o cors 
app.UseCors("projetoAngular");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
