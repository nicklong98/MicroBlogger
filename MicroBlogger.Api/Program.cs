using MicroBlogger.Api.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MicroBloggerContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("postgres")!);
    var isDevelopment = builder.Environment.IsDevelopment();
    options.EnableSensitiveDataLogging(isDevelopment);
    options.EnableDetailedErrors(isDevelopment);
});

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
