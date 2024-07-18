using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ECommerce.CommonRepository;
using ECommerce.Data;
using ECommerce.Repositories.Concrete;
using ECommerce.Repositories.Interface;
using ECommerce.Services.Concrete;
using ECommerce.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ECommerce.Entities; // Ensure correct namespace for your ApplicationUser class
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure the Entity Framework Core DbContext with SQL Server
builder.Services.AddDbContext<ApplicationDb>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
));

// Configure AutoMapper with the mapping profiles
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Register the generic repository and specific repositories for dependency injection
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Register the ProductRepository and ProductService for dependency injection
builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Register ProductRepository
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();

// Configure ASP.NET Core Identity with custom ApplicationUser
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDb>()
    .AddDefaultTokenProviders();

// Configure JWT authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

// Add controllers to the service collection
builder.Services.AddControllers()
    .AddJsonOptions(opts => opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())); // For JSON serialization of enums

// Register Swagger/OpenAPI for API documentation and testing
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

// Enable Swagger UI in development mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Serve static files (e.g., images) from the wwwroot folder
app.UseStaticFiles();

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS for security

app.UseAuthentication(); // Add authentication middleware
app.UseAuthorization(); // Enable authorization middleware to protect endpoints

app.MapControllers(); // Map controllers to handle incoming requests

app.Run(); // Run the application
