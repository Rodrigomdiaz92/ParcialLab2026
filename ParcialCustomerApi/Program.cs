using Microsoft.EntityFrameworkCore;
using ParcialCustomer.Domain.Interfaces;
using ParcialCustomer.Infraestructure.Data;
using ParcialCustomer.Infraestructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add entity framework and database context
builder.Services.AddDbContext<ApplicationDbConext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();








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
