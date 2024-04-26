using Microsoft.EntityFrameworkCore;
using PimAPI.Extension;
using PimProject.Application.Infra.Data.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRepository();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(x => x.AllowEmptyInputInBodyModelBinding = true);

builder.Services.AddDbContext<PimProjectDbContext>(options =>
{
    var cnn = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(cnn);
});




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
