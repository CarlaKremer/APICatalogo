using APICatalogo.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();// adiciona o servi�o de controladores
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();// adiciona servi�os para explorar os endpoint da API
builder.Services.AddSwaggerGen(); //adiciona servi�os para  gera��o da documenta��o interativa da API

string? mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(optionsAction =>
                optionsAction.UseMySql(mySqlConnection,
                ServerVersion.AutoDetect(mySqlConnection)));

// constroi inst�ncia da aplica��o com base nos servi�os definidos anteriomente:
var app = builder.Build();

// Configure the HTTP request pipeline. middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
