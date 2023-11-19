using Book_Service.Data;
using Book_Service.DTO;
using Book_Service.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;
builder.Services.AddDbContext<BookAppDbContext>(
    options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
    );
//Trial below. Adding a class for dependency injection
//builder.Services.AddSingleton<CommonResponse>();
builder.Services.AddAutoMapper(typeof(Program));
//builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
