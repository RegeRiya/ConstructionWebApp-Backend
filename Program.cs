using Microsoft.EntityFrameworkCore;
using PostgresWebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
//Entityframework for Database
builder.Services.AddEntityFrameworkNpgsql().
AddDbContext<ApiDbContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("MyWebApiConnection"))
);

//Enable CORS policy
builder.Services.AddCors(p => p.AddPolicy("disable cors", build => build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Use Cors
app.UseCors("disable cors");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
