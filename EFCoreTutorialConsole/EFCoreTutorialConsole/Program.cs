using EFCoreTutorialConsole;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SchoolContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("myconn"));
});
// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddAutoMapper(typeof(Program));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:5173")
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("https://localhost:7118")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});
var app = builder.Build();
app.UseCors(builder =>
{
    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
});

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

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
