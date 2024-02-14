using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();


builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductServise, ProductManager>();
builder.Services.AddSingleton<IProductDal, EfProductDal>();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseSwagger();
app.UseAuthorization();

app.MapControllers();

app.Run();
