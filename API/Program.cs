using API.Extensions;
using Domine.Data;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();
builder.Services.AddJwt(builder.Configuration);



//Comunicación
builder.Services.AddDbContext<ProjectTokensDbContext>(options =>{
string ConnectionStrings = builder.Configuration.GetConnectionString("ConexMySQLCampus");
options.UseMySql(ConnectionStrings,ServerVersion.AutoDetect(ConnectionStrings));
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

//app.UseAuthorization();

app.MapControllers();

app.Run();

