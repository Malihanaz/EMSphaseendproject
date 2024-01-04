using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EMSphaseendproject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EmpProfileContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmpProfileContext") ?? throw new InvalidOperationException("Connection string 'EmpProfileContext' not found.")));
builder.Services.AddDbContext<DeptMasterContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DeptMasterContext") ?? throw new InvalidOperationException("Connection string 'DeptMasterContext' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();
