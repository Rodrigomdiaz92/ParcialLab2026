using Microsoft.EntityFrameworkCore;
using ParcialProduct.Domain.Interfaces;
using ParcialProduct.Infraestructure.Data;
using ParcialProduct.Infraestructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add entity framework and database context
builder.Services.AddDbContext<ApplicationDbConext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//add configuration options


//add automapper
//builder.Services.AddAutoMapper(typeof(ProductMapping));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepository, ProductRepository>();










var app = builder.Build();

// Configure the HTTP request pipeline. Midelware 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

if(app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var seader = scope.ServiceProvider.GetRequiredService<ApplicationDbConext>();
        seader.Database.EnsureCreated();
    }
}

app.Run();
