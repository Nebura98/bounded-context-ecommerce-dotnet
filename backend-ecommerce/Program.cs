using Microsoft.EntityFrameworkCore;
using backend_ecommerce.Src.Shared.Infrastructure;
using backend_ecommerce.src.Backoffice.Products.Domain;
using backend_ecommerce.src.Backoffice.Products.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection with database
Action<DbContextOptionsBuilder> configureDbContext = options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSql"));
builder.Services.AddDbContext<DatabaseContext>(configureDbContext);
builder.Services.AddSingleton(new DatabaseContextFactory(configureDbContext));


//Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

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
