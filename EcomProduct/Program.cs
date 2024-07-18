//using System.Text;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.IdentityModel.Tokens;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;
//using System.Text.Json.Serialization;
//using EcomProduct.CommonRepository;
//using EcomProduct.Controllers;
//using EcomProduct.Entities;
//using EcomProduct.Repositories.Concrete;
//using EcomProduct.Repositories.Interface;
//using EcomProduct.Services.Concrete;
//using EcomProduct.Services.Interface;
//using Microsoft.OpenApi.Models;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//// Configure the Entity Framework Core DbContext with SQL Server
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
//    builder.Configuration.GetConnectionString("DefaultConnection")
//));

//// Configure AutoMapper with the mapping profiles
//builder.Services.AddAutoMapper(typeof(MappingProfile));

//// Register the generic repository and specific repositories for dependency injection
//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//// Register the ProductRepository and ProductService for dependency injection
//builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Register ProductRepository
//builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();

//// Configure ASP.NET Core Identity with custom ApplicationUser
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();

//// Configure JWT authentication
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//.AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration["Jwt:Issuer"],
//        ValidAudience = builder.Configuration["Jwt:Audience"],
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
//    };
//});

//// Add controllers to the service collection
//builder.Services.AddControllers()
//    .AddJsonOptions(opts => opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())); // For JSON serialization of enums

//// Register Swagger/OpenAPI for API documentation and testing
//builder.Services.AddEndpointsApiExplorer();
////builder.Services.AddSwaggerGen();



//builder.Services.AddSwaggerGen(config =>
//{
//    config.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Title = "Manish Kumar Singh",
//        Version = "v1"
//    });

//    config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        In = ParameterLocation.Header,
//        Description = "Please enter token",
//        Name = "Authorization",
//        Type = SecuritySchemeType.ApiKey,
//        BearerFormat = "JWT",
//        Scheme = "Bearer"
//    });

//    config.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type = ReferenceType.SecurityScheme,
//                    Id = "Bearer"
//                }
//            },
//            new string[] { }
//        }
//    });
//});



//var app = builder.Build();

//// Configure the HTTP request pipeline.

//// Enable Swagger UI in development mode
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//// Serve static files (e.g., images) from the wwwroot folder
//app.UseStaticFiles();

//app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS for security

//app.UseAuthentication(); // Add authentication middleware
//app.UseAuthorization(); // Enable authorization middleware to protect endpoints

//app.MapControllers(); // Map controllers to handle incoming requests

//app.Run(); // Run the application



using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;
using EcomProduct.CommonRepository;
using EcomProduct.Controllers;
using EcomProduct.Entities;
using EcomProduct.Repositories.Concrete;
using EcomProduct.Repositories.Interface;
using EcomProduct.Services.Concrete;
using EcomProduct.Services.Interface;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure the Entity Framework Core DbContext with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure ASP.NET Core Identity with custom ApplicationUser
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
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

// Configure AutoMapper with the mapping profiles
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Register the generic repository and specific repositories for dependency injection
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Register the ProductRepository and ProductService for dependency injection
builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Register ProductRepository
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();

// Add controllers to the service collection
builder.Services.AddControllers()
    .AddJsonOptions(opts => opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())); // For JSON serialization of enums

// Register Swagger/OpenAPI for API documentation and testing
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Manish Kumar Singh",
        Version = "v1"
    });

    config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });

    config.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

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

