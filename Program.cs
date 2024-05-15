using findfripes_dotnet.Database;
using findfripes_dotnet.Models;
using findfripes_dotnet.Repositories;
using findfripes_dotnet.Services;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PgFindfripesContext>();
builder.Services.AddIdentity<FFUser, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<PgFindfripesContext>()
    .AddDefaultTokenProviders();
builder.Services.AddScoped<IFripesRepository, FripesRepository>();
builder.Services.AddScoped<IAddressesRepository, AddressesRepository>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IFripesService, FripeService>();

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
