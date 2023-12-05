using Microsoft.EntityFrameworkCore;
using recover_forest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//TODO:conecio a la base de datos 
var connecionsting = builder.Configuration.GetConnectionString("defaulConection");
builder.Services.AddDbContext<AplicationDbContext>(opciones => opciones.UseSqlServer(connecionsting));

var app = builder.Build();

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
