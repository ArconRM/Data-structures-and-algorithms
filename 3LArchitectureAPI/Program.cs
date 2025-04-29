using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Mapping;
using _3LArchitecture.Repository;
using _3LArchitecture.Repository.Interfaces;
using _3LArchitecture.Service;
using _3LArchitecture.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepository<Toy>, ToyRepository>();
builder.Services.AddScoped<IProductService<Toy>, ToyService>();

builder.Services.AddScoped<IProductRepository<SportsEquipment>, SportsEquipmentRepository>();
builder.Services.AddScoped<IProductService<SportsEquipment>, SportsEquipmentService>();

builder.Services.AddScoped<IProductRepository<Book>, BookRepository>();
builder.Services.AddScoped<IProductService<Book>, BookService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();