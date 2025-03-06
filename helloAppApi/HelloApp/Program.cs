using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RepositoryLayer.Helper;
using System.Text;
using StackExchange.Redis;

var logger = NLog.LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();

try
{
    logger.Info("Starting application...");

    var builder = WebApplication.CreateBuilder(args);

    // Retrieve the database connection string
    var connectionString = builder.Configuration.GetConnectionString("SqlConnection");

    // Configure the application's DbContext to use SQL Server
    builder.Services.AddDbContext<HelloAppContext>(options =>
        options.UseSqlServer(connectionString));

    // Add Redis configuration correctly
    var redisConnectionString = builder.Configuration.GetConnectionString("Redis");
    if (string.IsNullOrEmpty(redisConnectionString))
    {
        throw new Exception("Redis connection string is missing in configuration");
    }

    builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
    {
        return ConnectionMultiplexer.Connect(redisConnectionString);
    });


    // Register services for dependency injection
    builder.Services.AddScoped<IRegisterHelloBL  , RegisterHelloBL>();
    builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();

    builder.Services.AddScoped<JwtHelper>();

    // Add controllers
    builder.Services.AddControllers();

    // Configure JWT Authentication
    var jwtSettings = builder.Configuration.GetSection("Jwt");
    var jwtKey = jwtSettings["Key"];

    if (string.IsNullOrEmpty(jwtKey))
    {
        throw new Exception("JWT Key is missing in configuration");
    }

    var key = Encoding.UTF8.GetBytes(jwtKey);

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidIssuer = jwtSettings["Issuer"],
                ValidAudience = jwtSettings["Audience"],
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };
        });

    // Register Swagger for API documentation
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "User Authentication API", Version = "v1" });

        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please enter a valid token",
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "Bearer"
        });

        c.AddSecurityRequirement(new OpenApiSecurityRequirement
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
                Array.Empty<string>()
            }
        });
    });


    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();

    // Configure the HTTP request pipeline
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();

    }
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application stopped due to an exception");
    throw;
}
finally
{
    LogManager.Shutdown(); 
}
