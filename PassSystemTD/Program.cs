using System.IdentityModel.Tokens.Jwt;
using System.Text;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PassSystemTD.Configurations;
using PassSystemTD.Data;
using PassSystemTD.Middleware;
using PassSystemTD.Services.Impls;
using PassSystemTD.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddControllers();
services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));
services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

JwtOptions jwtOptions = new();
configuration.GetSection(nameof(JwtOptions)).Bind(jwtOptions);

services.AddSingleton<JwtSecurityTokenHandler>();
services.AddSingleton(provider =>
{
    return new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtOptions.SecretKey)),
        ValidIssuer = jwtOptions.Issuer,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidAudience = jwtOptions.Audience,
        ValidateAudience = true
    };
});

builder.Services.AddSingleton(provider =>
{
    var cloudinaryConfig = builder.Configuration.GetSection("Cloudinary");
    return new Cloudinary(new Account(
        cloudinaryConfig["CloudName"],
        cloudinaryConfig["ApiKey"],
        cloudinaryConfig["ApiSecret"]));
});

services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtOptions.SecretKey)),
        ValidIssuer = jwtOptions.Issuer,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidAudience = jwtOptions.Audience,
        ValidateAudience = true
    };
});

services.AddScoped<IAccountService, AccountService>();
services.AddScoped<ITokenService, TokenService>();
services.AddScoped<IUserService, UserService>();
services.AddScoped<IPassService, PassService>();

//builder.Services.AddEndpointsApiExplorer();
services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        Description = "Authorized",
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});
services.AddCors(options =>
{
    options.AddPolicy("myPolicy", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithExposedHeaders("Content-Disposition");
    });
});

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(7162, listenOptions =>
    {
        listenOptions.UseHttps();
    });
    serverOptions.ListenAnyIP(5156);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("myPolicy");
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseAuthentication();
app.UseAuthorization(); 

app.MapControllers();

app.Run(); 